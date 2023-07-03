using Newtonsoft.Json;

namespace MythSportsApi.Models
{
    public class PropertyValue
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
