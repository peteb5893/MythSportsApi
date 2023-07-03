using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MythSportsApi.Models
{
    public class SportsEvent
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("start_date_local")]
        public DateTime StartDateLocal { get; set; }

        [JsonProperty("start_date_localSpecified")]
        public bool StartDateLocalSpecified { get; set; }

        [JsonProperty("scheduled_start_time_utc")]
        public DateTime ScheduledStartTimeUtc { get; set; }

        [JsonProperty("scheduled_start_time_utcSpecified")]
        public bool ScheduledStartTimeUtcSpecified { get; set; }

        [JsonProperty("end_time")]
        public DateTime EndTime { get; set; }

        [JsonProperty("end_timeSpecified")]
        public bool EndTimeSpecified { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("statusSpecified")]
        public bool StatusSpecified { get; set; }

        [JsonProperty("names")]
        public object Names { get; set; }

        [JsonProperty("state")]
        public List<IDictionary<string, string>> State { get; set; }

        [JsonProperty("current_state")]
        public object CurrentState { get; set; }

        [JsonProperty("attendance")]
        public int Attendance { get; set; }

        [JsonProperty("attendanceSpecified")]
        public bool AttendanceSpecified { get; set; }

        [JsonProperty("sport_id")]
        public string SportId { get; set; }

        [JsonProperty("venue_id")]
        public string VenueId { get; set; }

        [JsonProperty("start_venue_id")]
        public string StartVenueId { get; set; }

        [JsonProperty("finish_venue_id")]
        public string FinishVenueId { get; set; }

        [JsonProperty("phase_id")]
        public string PhaseId { get; set; }

        [JsonProperty("sports_organization_ids")]
        public List<string> SportsOrganizationIds { get; set; }

        [JsonProperty("parent_sports_event_ids")]
        public List<string> ParentSportsEventIds { get; set; }

        [JsonProperty("weather_conditions")]
        public WeatherConditions WeatherConditions { get; set; }

        [JsonProperty("event_attributes")]
        public object EventAttributes { get; set; }

        [JsonProperty("sports_discipline_id")]
        public string SportsDisciplineId { get; set; }

        [JsonProperty("sports_gender_id")]
        public string SportsGenderId { get; set; }

        [JsonProperty("sibling_order")]
        public int SiblingOrder { get; set; }

        [JsonProperty("sibling_orderSpecified")]
        public bool SiblingOrderSpecified { get; set; }

        [JsonProperty("schedule_status")]
        public int ScheduleStatus { get; set; }

        [JsonProperty("schedule_statusSpecified")]
        public bool ScheduleStatusSpecified { get; set; }

        [JsonProperty("result_status")]
        public int ResultStatus { get; set; }

        [JsonProperty("result_statusSpecified")]
        public bool ResultStatusSpecified { get; set; }

        [JsonProperty("properties")]
        public List<Property> Properties { get; set; }

        [JsonProperty("navigation_info")]
        public List<NavigationInfo> NavigationInfo { get; set; }

        [JsonProperty("event_type_detail")]
        public int EventTypeDetail { get; set; }

        [JsonProperty("event_type_detailSpecified")]
        public bool EventTypeDetailSpecified { get; set; }

        [JsonProperty("direct_parent_sports_event_id")]
        public string DirectParentSportsEventId { get; set; }

        [JsonProperty("home_participant_id")]
        public string HomeParticipantId { get; set; }

        [JsonProperty("away_participant_id")]
        public string AwayParticipantId { get; set; }

        [JsonProperty("participant_type")]
        public int ParticipantType { get; set; }

        [JsonProperty("participant_typeSpecified")]
        public bool ParticipantTypeSpecified { get; set; }

        [JsonProperty("date_and_time_info")]
        public DateAndTimeInfo DateAndTimeInfo { get; set; }

        [JsonProperty("translation_reference_id")]
        public string TranslationReferenceId { get; set; }

        [JsonProperty("sports")]
        public object Sports { get; set; }

        [JsonProperty("sports_organizations")]
        public object SportsOrganizations { get; set; }

        [JsonProperty("venues")]
        public object Venues { get; set; }

        [JsonProperty("child_sports_events")]
        public object ChildSportsEvents { get; set; }

        [JsonProperty("related_sports_events")]
        public List<RelatedSportsEvent> RelatedSportsEvents { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("xids")]
        public object Xids { get; set; }
    }
}
