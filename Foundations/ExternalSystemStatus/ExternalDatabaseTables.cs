using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalSystemStatus
{

    public class ExternalDatabaseTables
    {
        [JsonPropertyName("woocommerce_sessions")]
        public bool? WoocommerceSessions { get; set; }

        [JsonPropertyName("woocommerce_api_keys")]
        public bool? WoocommerceApiKeys { get; set; }

        [JsonPropertyName("woocommerce_attribute_taxonomies")]
        public bool? WoocommerceAttributeTaxonomies { get; set; }

        [JsonPropertyName("woocommerce_downloadable_product_permissions")]
        public bool? WoocommerceDownloadableProductPermissions { get; set; }

        [JsonPropertyName("woocommerce_order_items")]
        public bool? WoocommerceOrderItems { get; set; }

        [JsonPropertyName("woocommerce_order_itemmeta")]
        public bool? WoocommerceOrderItemmeta { get; set; }

        [JsonPropertyName("woocommerce_tax_rates")]
        public bool? WoocommerceTaxRates { get; set; }

        [JsonPropertyName("woocommerce_tax_rate_locations")]
        public bool? WoocommerceTaxRateLocations { get; set; }

        [JsonPropertyName("woocommerce_shipping_zones")]
        public bool? WoocommerceShippingZones { get; set; }

        [JsonPropertyName("woocommerce_shipping_zone_locations")]
        public bool? WoocommerceShippingZoneLocations { get; set; }

        [JsonPropertyName("woocommerce_shipping_zone_methods")]
        public bool? WoocommerceShippingZoneMethods { get; set; }

        [JsonPropertyName("woocommerce_payment_tokens")]
        public bool? WoocommercePaymentTokens { get; set; }

        [JsonPropertyName("woocommerce_payment_tokenmeta")]
        public bool? WoocommercePaymentTokenmeta { get; set; }
    }
}
