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
            return _dbSet.DFWGateLoungeFlightList.FirstOrDefault(d => d.AirlineCode == airlineCode && d.FlightNumber == flightNumber);
        }
        /// <summary>
        /// Check Currently Active Flight At Gate
        /// </summary>
        /// <param name="gateCode"></param>
        /// <returns></returns>
        public FlightInfoDataModel CheckActiveFlightAtGate(string gateCode)
        {
            return null;
        }
        /// <summary>
        /// Get Delayed Flights
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FlightInfoDataModel> GetDelayedFlights()
        {
            return null;
        }
    }
}
