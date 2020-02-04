using System;
using Newtonsoft.Json;

namespace TNTGoClone.Models
{
    public class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("poster")]
        public string Poster { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }
    }
}
