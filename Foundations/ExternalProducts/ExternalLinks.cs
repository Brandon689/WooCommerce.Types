using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    public class ExternalLinks
    {
        [JsonPropertyName("self")]
        public ExternalSelf[] Self { get; set; }

        [JsonPropertyName("collection")]
        public ExternalCollection[] Collection { get; set; }
    }
}
