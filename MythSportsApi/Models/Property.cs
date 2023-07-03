using Newtonsoft.Json;

namespace MythSportsApi.Models
{
    public class Property
    {
        [JsonProperty("key")]
        public int Key { get; set; }

        [JsonProperty("value")]
        public PropertyValue Value { get; set; }
    }
}
