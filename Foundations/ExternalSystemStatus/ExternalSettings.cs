using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalSystemStatus
{

    public class ExternalSettings
    {
        [JsonPropertyName("api_enabled")]
        public bool? ApiEnabled { get; set; }

        [JsonPropertyName("force_ssl")]
        public bool? ForceSsl { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("currency_position")]
        public string CurrencyPosition { get; set; }

        [JsonPropertyName("thousand_separator")]
        public string ThousandSeparator { get; set; }

        [JsonPropertyName("decimal_separator")]
        public string DecimalSeparator { get; set; }

        [JsonPropertyName("number_of_decimals")]
        public int? NumberOfDecimals { get; set; }

        [JsonPropertyName("geolocation_enabled")]
        public bool? GeolocationEnabled { get; set; }

        [JsonPropertyName("taxonomies")]
        public ExternalTaxonomies Taxonomies { get; set; }
    }
}
