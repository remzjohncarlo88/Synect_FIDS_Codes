using System.Text.Json.Serialization;

namespace FidsCodingAssignment.Models
{
    /// <summary>
    /// Main FID Model
    /// </summary>
    public class MainFIDModel
    {
        /// <summary>
        /// DFW GateLounge Flight List
        /// </summary>
        [JsonPropertyName("DFW GateLounge Flight List")]
        public List<FlightInfoDataModel>? DFWGateLoungeFlightList { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public string? Status { get; set; }
    }
}
