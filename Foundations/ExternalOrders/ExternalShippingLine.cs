using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.Orders
{
    public class ExternalShippingLine
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("method_title")]
        public string? MethodTitle { get; set; }

        [JsonPropertyName("method_id")]
        public string? MethodId { get; set; }

        [JsonPropertyName("total")]
        public string? Total { get; set; }

        [JsonPropertyName("total_tax")]
        public string? TotalTax { get; set; }

        [JsonPropertyName("taxes")]
        public List<object>? Taxes { get; set; }

        [JsonPropertyName("meta_data")]
        public List<object>? MetaData { get; set; }
    }
}
