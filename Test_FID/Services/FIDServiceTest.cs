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
                new FlightDataDisplayModel() { Classification = "DEP", FlightId = "QR 3905", OriginalTime = "2023-08-08T22:10:00Z", OriginPlace = null, ActualTimeOfArrival = null,
                Destination = "Boston", ActualTimeOfDeparture = null, AirlineName = "QATARI", GateCode = "E7", Status = "At 6:16p"}
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
    }
}
