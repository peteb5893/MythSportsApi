using System;
using Newtonsoft.Json;

namespace MythSportsApi.Models
{
    public class Meta
    {
        [JsonProperty("update_id")]
        public string UpdateId { get; set; }

        [JsonProperty("update_idSpecified")]
        public bool UpdateIdSpecified { get; set; }

        [JsonProperty("update_action")]
        public string UpdateAction { get; set; }

        [JsonProperty("update_date")]
        public DateTime UpdateDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }
}
