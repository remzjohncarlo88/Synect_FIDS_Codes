﻿using FidsCodingAssignment.Models;

namespace FidsCodingAssignment.Services
{
    /// <summary>
    /// IFlightInfoService
    /// </summary>
    public interface IFlightInfoService
    {
        /// <summary>
        /// Check Flight Status
        /// </summary>
        /// <param name="airlineCode">airline code</param>
        /// <param name="flightNumber">flight number</param>
        /// <returns></returns>
        FlightDataDisplayModel CheckFlightStatus(string airlineCode, int flightNumber);
        /// <summary>
        /// Get Delayed Flights
        /// </summary>
        /// <returns></returns>
        IEnumerable<FlightDataDisplayModel> GetDelayedFlights();
        /// <summary>
        /// Check Currently Active Flight At Gate
        /// </summary>
        /// <param name="gateCode"></param>
        /// <returns></returns>
        FlightDataDisplayModel CheckActiveFlightAtGate(string gateCode);
    }
}
