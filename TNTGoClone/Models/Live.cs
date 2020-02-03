using Newtonsoft.Json;

namespace TNTGoClone.Models
{
    public class Live
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }
    }
}
