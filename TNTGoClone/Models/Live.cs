using System.Text.Json.Serialization;

namespace TNTGoClone.Models
{
    public class Live
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("background")]
        public string Background { get; set; }

        [JsonPropertyName("is_locked")]
        public bool IsLocked { get; set; }
    }
}
