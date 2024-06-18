using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProductVariations
{
    public class ExternalVariationAttribute
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("option")]
        public string Option { get; set; }
    }
}
