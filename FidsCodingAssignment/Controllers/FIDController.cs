using FidsCodingAssignment.Models;
using FidsCodingAssignment.Services;
using Microsoft.AspNetCore.Mvc;

namespace FidsCodingAssignment.Controllers
{
    /// <summary>
    /// FDI Controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class FIDController : ControllerBase
    {
        private readonly IFlightInfoService _flightInfoService;

        /// <summary>
        /// FDIController constructor
        /// </summary>
        /// <param name="flightInfoService">flight info service object</param>
        public FIDController(IFlightInfoService flightInfoService)
        {
            _flightInfoService = flightInfoService;
        }

        /// <summary>
        /// Check Flight Status
        /// </summary>
        /// <param name="airlineCode">airline code</param>
        /// <param name="flightNumber">flight number</param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FlightDataDisplayModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("CheckFlightStatus")]
        public IActionResult CheckFlightStatus(string airlineCode, int flightNumber)
        {
            var flightStatus = _flightInfoService.CheckFlightStatus(airlineCode, flightNumber);

            if (flightStatus == null)
                return NotFound();

            return Ok(flightStatus);
        }

        /// <summary>
        /// Get Delayed Flight List
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<FlightDataDisplayModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("GetDelayedFlights")]
        public IActionResult GetDelayedFlights()
        {
            var delayedFlights = _flightInfoService.GetDelayedFlights();

            if (delayedFlights == null)
                return NotFound();

            return Ok(delayedFlights);
        }
    }
}