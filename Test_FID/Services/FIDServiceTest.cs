using FidsCodingAssignment.Models;
using FidsCodingAssignment.Repositories;
using FidsCodingAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_FID.Services
{
    public class FIDServiceTest : IFlightInfoService
    {
        private readonly List<FlightDataDisplayModel> _fids;
        public FIDServiceTest()
        {
            _fids = new List<FlightDataDisplayModel>()
            {
                new FlightDataDisplayModel() { Classification = "DEP", FlightId = "QR 3905", OriginalTime = Convert.ToDateTime("2023-08-08T22:10:00Z"), OriginPlace = null, ActualTimeOfArrival = null,
                    Destination = "Boston", ActualTimeOfDeparture = Convert.ToDateTime("2023-08-08T23:16:00Z"), AirlineName = "QATARI", GateCode = "E7", Status = "At 6:16p"},
                new FlightDataDisplayModel() { Classification = "ARR", FlightId = "TK 8658", OriginalTime = Convert.ToDateTime("2023-08-08T15:07:00Z"), OriginPlace = "Toronto", ActualTimeOfArrival = Convert.ToDateTime("2023-08-08T17:07:00Z"),
                    Destination = null, ActualTimeOfDeparture = null, AirlineName = "TURKAIR", GateCode = null, Status = "Delayed"},
                new FlightDataDisplayModel() { Classification = "DEP", FlightId = "TK 8659", OriginalTime = Convert.ToDateTime("2023-08-08T16:00:00Z"), OriginPlace = null, ActualTimeOfArrival = null,
                    Destination = "Toronto", ActualTimeOfDeparture = Convert.ToDateTime("2023-08-08T17:50:00Z"), AirlineName = "TURKAIR", GateCode = "E2", Status = "Delayed"}
            };
        }

        /// <summary>
        /// Check Flight Status
        /// </summary>
        /// <param name="airlineCode">airline code</param>
        /// <param name="flightNumber">flight number</param>
        /// <returns></returns>
        public FlightDataDisplayModel CheckFlightStatus(string airlineCode, int flightNumber)
        {
            return _fids.Where(a => a.FlightId == string.Concat(airlineCode, ' ', flightNumber)).FirstOrDefault();
        }

        /// <summary>
        /// Get Delayed Flights
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FlightDataDisplayModel> GetDelayedFlights()
        {
            int arrival_Time_Allowance = Convert.ToInt32(Environment.GetEnvironmentVariable("Arrival_Time_Allowance"));
            int departure_Time_Allowance = Convert.ToInt32(Environment.GetEnvironmentVariable("Departure_Time_Allowance"));

            List<FlightDataDisplayModel> fids = _fids.Where(a =>
                (DateTime.Compare(Convert.ToDateTime(a.Classification.Equals("ARR") ? a.ActualTimeOfArrival : a.ActualTimeOfDeparture), Convert.ToDateTime(a.OriginalTime)) >= 0)
                && (Convert.ToDateTime(a.Classification.Equals("ARR") ? a.ActualTimeOfArrival : a.ActualTimeOfDeparture).Subtract(Convert.ToDateTime(a.OriginalTime))).TotalMinutes
                > (a.Classification.Equals("ARR") ? arrival_Time_Allowance : departure_Time_Allowance)).ToList();

            return fids;
        }
    }
}
