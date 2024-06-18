using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalSystemStatus
{

    public class ExternalTaxonomies
    {
        [JsonPropertyName("external")]
        public string External { get; set; }

        [JsonPropertyName("grouped")]
        public string Grouped { get; set; }

        [JsonPropertyName("simple")]
        public string Simple { get; set; }

        [JsonPropertyName("variable")]
        public string Variable { get; set; }
    }
}
