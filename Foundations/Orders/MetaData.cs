using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.Orders
{
    public class MetaData
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
