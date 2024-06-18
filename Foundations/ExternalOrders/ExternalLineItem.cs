using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.Orders
{
    public class ExternalLineItem
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("product_id")]
        public int? ProductId { get; set; }

        [JsonPropertyName("variation_id")]
        public int? VariationId { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("tax_class")]
        public string? TaxClass { get; set; }

        [JsonPropertyName("subtotal")]
        public string? Subtotal { get; set; }

        [JsonPropertyName("subtotal_tax")]
        public string? SubtotalTax { get; set; }

        [JsonPropertyName("total")]
        public string? Total { get; set; }

        [JsonPropertyName("total_tax")]
        public string? TotalTax { get; set; }

        [JsonPropertyName("taxes")]
        public List<Taxis>? Taxes { get; set; }

        [JsonPropertyName("meta_data")]
        public List<MetaData>? MetaData { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("price")]
        public string? Price { get; set; }
    }
}
