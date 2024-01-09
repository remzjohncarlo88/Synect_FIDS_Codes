using FidsCodingAssignment.Models;

namespace FidsCodingAssignment.Repositories
{
    /// <summary>
    /// IFlightInfoRepository
    /// </summary>
    public interface IFlightInfoRepository
    {
        /// <summary>
        /// Get All Flight Information Data from JSON file
        /// </summary>
        /// <returns></returns>
        MainFIDModel GetAll();
        /// <summary>
        /// Check Flight Status
        /// </summary>
        /// <param name="airlineCode">airline code</param>
        /// <param name="flightNumber">flight number</param>
        /// <returns></returns>
        FlightInfoDataModel CheckFlightStatus(string airlineCode, int flightNumber);
        /// <summary>
        /// Check Currently Active Flight At Gate
        /// </summary>
        /// <param name="gateCode"></param>
        /// <returns></returns>
        FlightInfoDataModel CheckActiveFlightAtGate(string gateCode);
        /// <summary>
        /// Get Delayed Flights
        /// </summary>
        /// <returns></returns>
        IEnumerable<FlightInfoDataModel> GetDelayedFlights();
    }
}
