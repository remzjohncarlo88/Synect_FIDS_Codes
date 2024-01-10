using FidsCodingAssignment.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text.Json;

namespace FidsCodingAssignment.Repositories
{
    /// <summary>
    /// Flight Information Repository
    /// </summary>
    public class FlightInfoRepository : IFlightInfoRepository
    {
        private readonly MainFIDModel _dbSet;
        private readonly JsonSerializerOptions _options = new()
        {
            PropertyNameCaseInsensitive = true
        };

        /// <summary>
        /// FlightInfoRepository constructor
        /// </summary>
        public FlightInfoRepository()
        {
            _dbSet = GetAll();
        }

        /// <summary>
        /// Get All Flight Information Data from JSON file
        /// </summary>
        /// <returns></returns>
        public MainFIDModel GetAll()
        {
            var jsonPath = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Data\\rawData.json"));
            MainFIDModel? fids = JsonSerializer.Deserialize<MainFIDModel>(jsonPath, _options);

            return fids;
        }
        /// <summary>
        /// Check Flight Status
        /// </summary>
        /// <param name="airlineCode">airline code</param>
        /// <param name="flightNumber">flight number</param>
        /// <returns></returns>
        public FlightInfoDataModel CheckFlightStatus(string airlineCode, int flightNumber)
        {
            return _dbSet.DFWGateLoungeFlightList.FirstOrDefault(d => 
                    d.AirlineCode == airlineCode.ToUpper() 
                    && d.FlightNumber == flightNumber);
        }
        /// <summary>
        /// Get Delayed Flights
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FlightInfoDataModel> GetDelayedFlights()
        {
            int arrival_Time_Allowance = Convert.ToInt32(Environment.GetEnvironmentVariable("Arrival_Time_Allowance"));
            int departure_Time_Allowance = Convert.ToInt32(Environment.GetEnvironmentVariable("Departure_Time_Allowance"));

            List<FlightInfoDataModel> fids = _dbSet.DFWGateLoungeFlightList.Where(a => 
                (DateTime.Compare(Convert.ToDateTime(a.EstimatedTime), Convert.ToDateTime(a.ScheduleTime)) >= 0)
                && (Convert.ToDateTime(a.EstimatedTime).Subtract(Convert.ToDateTime(a.ScheduleTime))).TotalMinutes 
                > (a.ArrDep.Equals("ARR") ? arrival_Time_Allowance : departure_Time_Allowance)).ToList();

            return fids;
        }
        /// <summary>
        /// Check Currently Active Flight At Gate
        /// </summary>
        /// <param name="gateCode"></param>
        /// <returns></returns>
        public FlightInfoDataModel CheckActiveFlightAtGate(string gateCode)
        {
            int boarding_Time_Minutes = Convert.ToInt32(Environment.GetEnvironmentVariable("Boarding_Time_Minutes"));

            return _dbSet.DFWGateLoungeFlightList.FirstOrDefault(d => d.GateCode == gateCode.ToUpper()
                    && d.ArrDep.Equals("DEP")
                    && DateTime.Compare(DateTime.Now, Convert.ToDateTime(d.EstimatedTime)) < 0
                    && DateTime.Now.Subtract(Convert.ToDateTime(d.ScheduleTime)).TotalMinutes <= boarding_Time_Minutes);
        }
    }
}
