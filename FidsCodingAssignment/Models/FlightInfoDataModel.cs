using System.Globalization;
using System.Text.Json.Serialization;

namespace FidsCodingAssignment.Models
{
    /// <summary>
    /// Flight Information Data Model
    /// </summary>
    public class FlightInfoDataModel
    {
        /// <summary>
        /// Aircraft Registration Number
        /// </summary>
        public string? AircraftRegNumber { get; set; }
        /// <summary>
        /// Parent Flight Id
        /// </summary>
        public Nullable<int> ParentFlightId { get; set; }
        /// <summary>
        /// Remote Airport SCH DTM
        /// </summary>
        [JsonPropertyName("Remote_Airport_SCH_DTM")]
        public string? RemoteAirportSchDtm { get; set; }
        /// <summary>
        /// Remote Airport ACT DTM
        /// </summary>
        [JsonPropertyName("Remote_Airport_ACT_DTM")]
        public string? RemoteAirportActDtm { get; set; }
        /// <summary>
        /// Airport Code
        /// </summary>
        public string? AirportCode { get; set; }
        /// <summary>
        /// Event Time
        /// </summary>
        public string? EventTime { get; set; }
        /// <summary>
        /// Airline Code
        /// </summary>
        public string? AirlineCode { get; set; }
        /// <summary>
        /// Parrent Suffix
        /// </summary>
        public string? ParrentSuffix { get; set; }
        /// <summary>
        /// Suffix
        /// </summary>
        public string? Suffix { get; set; }
        /// <summary>
        /// Via Airport Codes
        /// </summary>
        public string? ViaAirportCodes { get; set; }
        /// <summary>
        /// Scheduled Time
        /// </summary>
        [JsonPropertyName("Sched_Time")]
        public string? ScheduleTime { get; set; }
        /// <summary>
        /// Arr Dep
        /// </summary>
        public string ArrDep { get; set; } = string.Empty;
        /// <summary>
        /// bag belt
        /// </summary>
        public string? bagbelt { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [JsonPropertyName("City_Name")]
        public string? CityName { get; set; }
        /// <summary>
        /// Flight Type
        /// </summary>
        public string? FlightType { get; set; }
        /// <summary>
        /// Remote Airport EST DTM
        /// </summary>
        [JsonPropertyName("Remote_Airport_EST_DTM")]
        public string? RemoteAirportEstDtm { get; set; }
        /// <summary>
        /// Event
        /// </summary>
        public string? Event { get; set; }
        /// <summary>
        /// Aircraft Type
        /// </summary>
        public string? AircraftType { get; set; }
        /// <summary>
        /// Tail
        /// </summary>
        public string? Tail { get; set; }
        /// <summary>
        /// Flight Number
        /// </summary>
        public Nullable<int> FlightNumber { get; set; }
        /// <summary>
        /// Flight Id
        /// </summary>
        public Nullable<int> FlightId { get; set; }
        /// <summary>
        /// Terminal Code
        /// </summary>
        public string? TerminalCode { get; set; }
        /// <summary>
        /// Airline Name
        /// </summary>
        [JsonPropertyName("Airline_Name")]
        public string? AirlineName { get; set; }
        /// <summary>
        /// Airline Time
        /// </summary>
        [JsonPropertyName("Airline_Time")]
        public string? AirlineTime { get; set; }
        /// <summary>
        /// Flight Status Code
        /// </summary>
        public string? FlightStatusCode { get; set; }
        /// <summary>
        /// Parent Airline Code
        /// </summary>
        public string? ParentAirlineCode { get; set; }
        /// <summary>
        /// Parent FLT Number
        /// </summary>
        public Nullable<int> ParentFLTNumber { get; set; }
        /// <summary>
        /// Gate Code
        /// </summary>
        public string? GateCode { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        public string? Remarks { get; set; }
        /// <summary>
        /// Estimated Time
        /// </summary>
        [JsonPropertyName("Estimated_Time")]
        public string? EstimatedTime { get; set; }
        /// <summary>
        /// Dep Boarding Start DTM
        /// </summary>
        [JsonPropertyName("Dep_BoardingStart_DTM")]
        public string? DepBoardingStartDtm { get; set; }
    }
}
