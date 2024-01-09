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
            FlightDataDisplayModel fid = new FlightDataDisplayModel();

            if (_flightInfoDataModel != null)
            {
                bool isArrival = _flightInfoDataModel.ArrDep.Equals("ARR") ? true : false;

                fid.Classification = isArrival ? "ARRIVAL" : "DEPARTURE";
                fid.FlightId = string.Concat(_flightInfoDataModel.AirlineCode, ' ', _flightInfoDataModel.FlightNumber);
                fid.OriginalTime = _flightInfoDataModel.ScheduleTime;
                fid.AirlineName = _flightInfoDataModel.AirlineName;
                fid.Status = _flightInfoDataModel.Remarks;

                if (isArrival)
                {
                    fid.OriginPlace = _flightInfoDataModel.CityName;
                    fid.ActualTimeOfArrival = _flightInfoDataModel.EstimatedTime;
                }
                else
                {
                    fid.Destination = _flightInfoDataModel.CityName;
                    fid.GateCode = _flightInfoDataModel.GateCode;
                }
            }

            return fid;
        }
    }
}
