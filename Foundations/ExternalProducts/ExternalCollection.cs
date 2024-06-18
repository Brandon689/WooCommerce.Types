using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    public class ExternalCollection
    {
        [JsonPropertyName("href")]
        public string? Href { get; set; }
    }
}
