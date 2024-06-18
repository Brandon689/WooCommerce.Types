using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    public class ExternalTag
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }
    }
}
