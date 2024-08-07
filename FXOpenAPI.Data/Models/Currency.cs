using System.Text.Json.Serialization;

namespace FXOpenAPI.Data.Models
{
    public class Currency
    {
        [JsonPropertyName("Name")]
        public required string Name { get; set; }

        [JsonPropertyName("Precision")]
        public int Precision { get; set; }

        [JsonPropertyName("Description")]
        public required string Description { get; set; }

        [JsonPropertyName("Type")]
        public required string Type { get; set; }

        [JsonPropertyName("Tax")]
        public double Tax { get; set; }

        [JsonPropertyName("DefaultStockFee")]
        public int DefaultStockFee { get; set; }

        [JsonPropertyName("ExposureSwapSize")]
        public int ExposureSwapSize { get; set; }

        [JsonPropertyName("InterestRate")]
        public int InterestRate { get; set; }

        [JsonPropertyName("InterestMarkup")]
        public int InterestMarkup { get; set; }
    }
}
