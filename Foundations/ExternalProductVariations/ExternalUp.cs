using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProductVariations
{
    public class ExternalUp
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }
    }
}
