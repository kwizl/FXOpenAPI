using System.Text.Json.Serialization;

namespace FXOpenAPI.Data.Models
{
    public class QuoteHistoryBarsAskBidInfo
    {
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
