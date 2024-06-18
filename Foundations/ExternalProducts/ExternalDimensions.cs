using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    public class ExternalDimensions
    {
        [JsonPropertyName("length")]
        public string? Length { get; set; }

        [JsonPropertyName("width")]
        public string? Width { get; set; }

        [JsonPropertyName("height")]
        public string? Height { get; set; }
    }
}
