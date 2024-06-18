using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    public class ExternalDefaultAttribute
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("option")]
        public string? Option { get; set; }
    }
}
