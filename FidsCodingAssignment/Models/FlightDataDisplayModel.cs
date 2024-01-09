namespace FidsCodingAssignment.Models
{
    /// <summary>
    /// Flight Data Display Model
    /// </summary>
    public class FlightDataDisplayModel
    {
        /// <summary>
        /// Classification (Arrival/Departure)
        /// </summary>
        public string? Classification { get; set; }
        /// <summary>
        /// Airline Code + FlightNumber
        /// </summary>
        public string? FlightId { get; set; }
        /// <summary>
        /// Original Time (Departure)
        /// </summary>
        public string? OriginalTime { get; set; }
        /// <summary>
        /// Place of Origin (Arrival)
        /// </summary>
        public string? OriginPlace { get; set; }
        /// <summary>
        /// Actual Time Of Arrival
        /// </summary>
        public string? ActualTimeOfArrival { get; set; }
        /// <summary>
        /// Destination (Departure)
        /// </summary>
        public string? Destination { get; set; }
        /// <summary>
        /// Actual Time Of Departure
        /// </summary>
        public string? ActualTimeOfDeparture { get; set; }
        /// <summary>
        /// Airline Name
        /// </summary>
        public string? AirlineName { get; set; }
        /// <summary>
        /// Gate Code
        /// </summary>
        public string? GateCode { get; set; }
        /// <summary>
        /// Flight Status (Departure)
        /// </summary>
        public string? Status { get; set; }
    }
}
