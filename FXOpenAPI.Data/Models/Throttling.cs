using System.Text.Json.Serialization;

namespace FXOpenAPI.Data.Models
{
    public class Throttling
    {
        [JsonPropertyName("Protocol")]
        public required string Protocol { get; set; }

        [JsonPropertyName("SessionsPerAccount")]
        public int SessionsPerAccount { get; set; }

        [JsonPropertyName("RequestsPerSecond")]
        public int RequestsPerSecond { get; set; }

        [JsonPropertyName("ThrottlingMethods")]
        public List<object>? ThrottlingMethods { get; set; }

        [JsonPropertyName("ConcurrentRequestCount")]
        public int ConcurrentRequestCount { get; set; }
    }
}
