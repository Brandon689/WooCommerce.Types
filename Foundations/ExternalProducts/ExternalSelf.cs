using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    public class ExternalSelf
    {
        [JsonPropertyName("href")]
        public string? Href { get; set; }
    }
}
