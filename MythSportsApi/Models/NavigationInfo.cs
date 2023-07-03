using Newtonsoft.Json;

namespace MythSportsApi.Models
{
    public class NavigationInfo
    {
        [JsonProperty("has_standings")]
        public bool HasStandings { get; set; }

        [JsonProperty("is_knockout")]
        public bool IsKnockout { get; set; }
    }
}
