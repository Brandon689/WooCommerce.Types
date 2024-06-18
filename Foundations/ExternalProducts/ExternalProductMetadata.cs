using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    public class ExternalProductMetadata
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("key")]
        public string? Key { get; set; }

        [JsonPropertyName("value")]
        public object? Value { get; set; }
    }
}
