using FidsCodingAssignment.Models;
using FidsCodingAssignment.Repositories;

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
            FlightDataDisplayModel flightDataDisplayModel = new FlightDataDisplayModel();
            flightDataDisplayModel.Classification = _flightInfoDataModel.ArrDep;
            flightDataDisplayModel.AirlineName = _flightInfoDataModel.AirlineName;
            flightDataDisplayModel.AirlineCode = _flightInfoDataModel.AirlineCode;
            flightDataDisplayModel.FlightNumber = _flightInfoDataModel.FlightNumber;
            flightDataDisplayModel.OriginalTime = _flightInfoDataModel.ScheduleTime;
            flightDataDisplayModel.OriginPlace = _flightInfoDataModel.CityName;
            flightDataDisplayModel.ActualTimeOfArrival = _flightInfoDataModel.EstimatedTime;

            return flightDataDisplayModel;
        }
    }
}
