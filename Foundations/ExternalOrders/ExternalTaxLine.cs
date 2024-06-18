using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.Orders
{
    public class ExternalTaxLine
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("rate_code")]
        public string? RateCode { get; set; }

        [JsonPropertyName("rate_id")]
        public int? RateId { get; set; }

        [JsonPropertyName("label")]
        public string? Label { get; set; }

        [JsonPropertyName("compound")]
        public bool? Compound { get; set; }

        [JsonPropertyName("tax_total")]
        public string? TaxTotal { get; set; }

        [JsonPropertyName("shipping_tax_total")]
        public string? ShippingTaxTotal { get; set; }

        [JsonPropertyName("meta_data")]
        public List<object>? MetaData { get; set; }
    }
}
