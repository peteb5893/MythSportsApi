using Newtonsoft.Json;

namespace MythSportsApi.Models
{
    public class RelatedSportsEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("type_detail")]
        public string TypeDetail { get; set; }

        [JsonProperty("depth")]
        public string Depth { get; set; }

        [JsonProperty("navigation_info")]
        public NavigationInfo NavigationInfo { get; set; }
    }
}
