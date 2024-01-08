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
        /// Original Time (Arrival/Departure)
        /// </summary>
        public string? OriginalTime { get; set; }
        /// <summary>
        /// Place of Origin (Arrival)
        /// </summary>
        public string? OriginPlace { get; set; }
        /// <summary>
        /// Flight Number
        /// </summary>
        public Nullable<int> FlightNumber { get; set; }
        /// <summary>
        /// Airline Code
        /// </summary>
        public string? AirlineCode { get; set; }
        /// <summary>
        /// Actual Time Of Arrival
        /// </summary>
        public string? ActualTimeOfArrival { get; set; }
        /// <summary>
        /// Actual Time Of Departure
        /// </summary>
        public string? ActualTimeOfDeparture { get; set; }
        /// <summary>
        /// Airline Name
        /// </summary>
        public string? AirlineName { get; set; }
        /// <summary>
        /// Destination (Departure)
        /// </summary>
        public string? Destination { get; set; }
        /// <summary>
        /// Flight Status (Departure)
        /// </summary>
        public string? FlightStatus { get; set; }
        /// <summary>
        /// Gate Code
        /// </summary>
        public string? GateCode { get; set; }
    }
}
