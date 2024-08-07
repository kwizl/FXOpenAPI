using System.Text.Json.Serialization;

namespace FXOpenAPI.Data.Models
{
    public class CurrencyType
    {
        [JsonPropertyName("Name")]
        public required string Name { get; set; }

        [JsonPropertyName("Description")]
        public required string Description { get; set; }
    }
}
