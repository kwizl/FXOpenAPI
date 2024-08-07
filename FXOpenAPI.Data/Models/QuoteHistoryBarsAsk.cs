using System.Text.Json.Serialization;

namespace FXOpenAPI.Data.Models
{
    public class QuoteHistoryBarsAsk
    {
        [JsonPropertyName("From")]
        public int From { get; set; }

        [JsonPropertyName("To")]
        public int To { get; set; }

        [JsonPropertyName("Bars")]
        public List<Bar>? Bars { get; set; }

        [JsonPropertyName("Symbol")]
        public required string Symbol { get; set; }

        [JsonPropertyName("AvailableFrom")]
        public int AvailableFrom { get; set; }

        [JsonPropertyName("AvailableTo")]
        public int AvailableTo { get; set; }

        [JsonPropertyName("LastTickId")]
        public required string LastTickId { get; set; }
    }
}
