using FidsCodingAssignment.Models;
using FidsCodingAssignment.Repositories;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace FidsCodingAssignment.Services
{
    /// <summary>
    /// FlightInfoService
    /// </summary>
    public class FlightInfoService : IFlightInfoService
    {
        private readonly IFlightInfoRepository _flightInfoRepository;

        /// <summary>
        /// FlightInfoService constructor
        /// </summary>
        /// <param name="flightInfoRepository">Flight Info Repository object</param>
        public FlightInfoService(IFlightInfoRepository flightInfoRepository)
        {
            _flightInfoRepository = flightInfoRepository;
        }

        /// <summary>
        /// Check Flight Status
        /// </summary>
        /// <param name="airlineCode">airline code</param>
        /// <param name="flightNumber">flight number</param>
        /// <returns></returns>
        public FlightDataDisplayModel CheckFlightStatus(string airlineCode, int flightNumber)
        {
            FlightInfoDataModel _flightInfoDataModel = _flightInfoRepository.CheckFlightStatus(airlineCode, flightNumber);
            FlightDataDisplayModel fid = new FlightDataDisplayModel();

            if (_flightInfoDataModel != null)
            {
                bool isArrival = _flightInfoDataModel.ArrDep.Equals("ARR") ? true : false;
                fid.Classification = _flightInfoDataModel.ArrDep.Equals("ARR") ? "ARRIVAL" : "DEPARTURE";
                fid.FlightId = string.Concat(_flightInfoDataModel.AirlineCode, ' ', _flightInfoDataModel.FlightNumber);
                fid.OriginalTime = _flightInfoDataModel.ScheduleTime;
                fid.AirlineName = _flightInfoDataModel.AirlineName;
                fid.OriginPlace = isArrival ? _flightInfoDataModel.CityName : null;
                fid.ActualTimeOfArrival = isArrival ? _flightInfoDataModel.EstimatedTime : null;
                fid.Destination = !isArrival ? _flightInfoDataModel.CityName : null;
                fid.GateCode = !isArrival ? _flightInfoDataModel.GateCode : null;
                fid.ActualTimeOfDeparture = !isArrival ? _flightInfoDataModel.EstimatedTime : null;
            }

            return fid;
        }
        /// <summary>
        /// Get Delayed Flights
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FlightDataDisplayModel> GetDelayedFlights()
        {
            IEnumerable<FlightInfoDataModel> _delayedFlights = _flightInfoRepository.GetDelayedFlights();
            List<FlightDataDisplayModel> delayedFlightList = new List<FlightDataDisplayModel>();

            if (_delayedFlights != null)
            {
                delayedFlightList = _delayedFlights
                    .Select(x => new FlightDataDisplayModel {
                        Classification = x.ArrDep.Equals("ARR") ? "ARRIVAL" : "DEPARTURE",
                        FlightId = string.Concat(x.AirlineCode, ' ', x.FlightNumber),
                        OriginalTime = x.ScheduleTime,
                        AirlineName = x.AirlineName,
                        OriginPlace = x.ArrDep.Equals("ARR") ? x.CityName : null,
                        ActualTimeOfArrival = x.ArrDep.Equals("ARR") ? x.EstimatedTime : null,
                        Destination = !x.ArrDep.Equals("ARR") ? x.CityName : null,
                        GateCode = !x.ArrDep.Equals("ARR") ? x.GateCode : null,
                        ActualTimeOfDeparture = !x.ArrDep.Equals("ARR") ? x.EstimatedTime : null,
                        Status = "Delayed"
                    }).ToList();
            }

            return delayedFlightList;
        }
    }
}
