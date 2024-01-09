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
    public class FDIController : ControllerBase
    {
        private readonly ILogger<FDIController> _logger;
        private readonly IFlightInfoService _flightInfoService;

        /// <summary>
        /// FDIController constructor
        /// </summary>
        /// <param name="logger">logger object</param>
        /// <param name="flightInfoService">flight info service object</param>
        public FDIController(ILogger<FDIController> logger, IFlightInfoService flightInfoService)
        {
            _logger = logger;
            _flightInfoService = flightInfoService;
        }

        /// <summary>
        /// Check Flight Status
        /// </summary>
        /// <param name="airlineCode">airline code</param>
        /// <param name="flightNumber">flight number</param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FlightDataDisplayModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("CheckFlightStatus")]        
        public FlightDataDisplayModel CheckFlightStatus(string airlineCode, int flightNumber)
        {
            var flightStatus = _flightInfoService.CheckFlightStatus(airlineCode, flightNumber);
            return flightStatus;
        }
    }
}