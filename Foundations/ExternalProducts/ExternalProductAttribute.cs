using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    public class ExternalProductAttribute
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } = 0;

        [JsonPropertyName("position")]
        public int Position { get; set; } = 0;

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("visible")]
        public bool Visible { get; set; } = true;

        [JsonPropertyName("variation")]
        public bool Variation { get; set; }

        [JsonPropertyName("options")]
        public string[] Options { get; set; }
    }
}
