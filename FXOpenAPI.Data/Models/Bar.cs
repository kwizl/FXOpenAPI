using System.Text.Json.Serialization;

namespace FXOpenAPI.Data.Models
{
    public class Bar
    {
        [JsonPropertyName("Timestamp")]
        public long Timestamp { get; set; }

        [JsonPropertyName("Open")]
        public double Open { get; set; }

        [JsonPropertyName("High")]
        public double High { get; set; }

        [JsonPropertyName("Low")]
        public double Low { get; set; }

        [JsonPropertyName("Close")]
        public double Close { get; set; }

        [JsonPropertyName("Volume")]
        public long Volume { get; set; }
    }
}
