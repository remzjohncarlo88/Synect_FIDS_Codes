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
        DateTime? _remoteAirportSchDtm;
        /// <summary>
        /// Remote Airport SCH DTM
        /// </summary>
        [JsonPropertyName("Remote_Airport_SCH_DTM")]
        public DateTime? RemoteAirportSchDtm
        {
            get { return _remoteAirportSchDtm; }
            set { _remoteAirportSchDtm = Convert.ToDateTime(value); }
        }
        DateTime? _remoteAirportActDtm;
        /// <summary>
        /// Remote Airport ACT DTM
        /// </summary>
        [JsonPropertyName("Remote_Airport_ACT_DTM")]
        public DateTime? RemoteAirportActDtm
        {
            get { return _remoteAirportActDtm; }
            set { _remoteAirportActDtm = Convert.ToDateTime(value); }
        }
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
        DateTime? _scheduleTime;
        /// <summary>
        /// Scheduled Time
        /// </summary>
        [JsonPropertyName("Sched_Time")]
        public DateTime? ScheduleTime
        {
            get { return _scheduleTime; }
            set { _scheduleTime = Convert.ToDateTime(value); }
        }
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
        DateTime? _remoteAirportEstDtm;
        /// <summary>
        /// Airline Time
        /// </summary>
        [JsonPropertyName("Remote_Airport_EST_DTM")]
        public DateTime? RemoteAirportEstDtm
        {
            get { return _remoteAirportEstDtm; }
            set { _remoteAirportEstDtm = Convert.ToDateTime(value); }
        }
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
        DateTime? _actualTimee;
        /// <summary>
        /// Airline Time
        /// </summary>
        [JsonPropertyName("Actual_Time")]
        public DateTime? ActualTime
        {
            get { return _actualTimee; }
            set { _actualTimee = Convert.ToDateTime(value); }
        }
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
        DateTime? _estimatedTime;
        /// <summary>
        /// Airline Time
        /// </summary>
        [JsonPropertyName("Estimated_Time")]
        public DateTime? EstimatedTime
        {
            get { return _estimatedTime; }
            set { _estimatedTime = Convert.ToDateTime(value); }
        }
        /// <summary>
        /// Dep Boarding Start DTM
        /// </summary>
        [JsonPropertyName("Dep_BoardingStart_DTM")]
        public string? DepBoardingStartDtm { get; set; }
    }
}
