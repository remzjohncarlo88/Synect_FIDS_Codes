using FidsCodingAssignment.Models;
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

        /// <summary>
        /// FDIController constructor
        /// </summary>
        /// <param name="logger"></param>
        public FDIController(ILogger<FDIController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// GetFlightInfoDataModelbyID
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetFlightInfoDataModelbyID")]
        public List<FlightInfoDataModel> GetFlightInfoDataModel()
        {
            List<FlightInfoDataModel> flightInfoDataModel = new List<FlightInfoDataModel>();
            return flightInfoDataModel;
        }
    }
}