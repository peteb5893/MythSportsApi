using Newtonsoft.Json;
using System;

namespace MythSportsApi.Models
{
    public class DateAndTimeInfo
    {
        [JsonProperty("scheduled_start_time_utc")]
        public DateTime ScheduledStartTimeUtc { get; set; }

        [JsonProperty("scheduled_start_time_utcSpecified")]
        public bool ScheduledStartTimeUtcSpecified { get; set; }

        [JsonProperty("scheduled_end_time_utc")]
        public DateTime ScheduledEndTimeUtc { get; set; }

        [JsonProperty("scheduled_end_time_utcSpecified")]
        public bool ScheduledEndTimeUtcSpecified { get; set; }

        [JsonProperty("actual_start_time_utc")]
        public DateTime ActualStartTimeUtc { get; set; }

        [JsonProperty("actual_start_time_utcSpecified")]
        public bool ActualStartTimeUtcSpecified { get; set; }

        [JsonProperty("actual_end_time_utc")]
        public DateTime ActualEndTimeUtc { get; set; }

        [JsonProperty("actual_end_time_utcSpecified")]
        public bool ActualEndTimeUtcSpecified { get; set; }

        [JsonProperty("start_date_local")]
        public DateTime StartDateLocal { get; set; }

        [JsonProperty("start_date_localSpecified")]
        public bool StartDateLocalSpecified { get; set; }

        [JsonProperty("end_date_local")]
        public DateTime EndDateLocal { get; set; }

        [JsonProperty("end_date_localSpecified")]
        public bool EndDateLocalSpecified { get; set; }
    }
}
