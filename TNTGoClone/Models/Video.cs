using System.Text.Json.Serialization;

namespace TNTGoClone.Models
{
    public abstract class Video
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("poster")]
        public string Poster { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        [JsonPropertyName("is_locked")]
        public bool IsLocked { get; set; }
    }
}
