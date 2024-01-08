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
        private readonly IEnumerable<FlightInfoDataModel> _dbSet;
        private readonly JsonSerializerOptions _options = new()
        {
            PropertyNameCaseInsensitive = false
        };

        /// <summary>
        /// FlightInfoRepository constructor
        /// </summary>
        /// <param name="context"></param>
        public FlightInfoRepository(DbContext context)
        {
            _dbSet = GetAll();
        }

        /// <summary>
        /// Get All Flight Information Data from JSON file
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FlightInfoDataModel> GetAll()
        {
            var json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "rawData.json"));
            List<FlightInfoDataModel>? fids = JsonSerializer.Deserialize<List<FlightInfoDataModel>>(json, _options);
            
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
            return _dbSet.FirstOrDefault(d => d.AirlineCode == airlineCode && d.FlightNumber == flightNumber);
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
