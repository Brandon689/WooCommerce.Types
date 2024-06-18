using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalSystemStatus
{

    public class ExternalPage
    {
        [JsonPropertyName("page_name")]
        public string? PageName { get; set; }

        [JsonPropertyName("page_id")]
        public string? PageId { get; set; }

        [JsonPropertyName("page_set")]
        public bool? PageSet { get; set; }

        [JsonPropertyName("page_exists")]
        public bool? PageExists { get; set; }

        [JsonPropertyName("page_visible")]
        public bool? PageVisible { get; set; }

        [JsonPropertyName("shortcode")]
        public string? Shortcode { get; set; }

        [JsonPropertyName("shortcode_required")]
        public bool? ShortcodeRequired { get; set; }

        [JsonPropertyName("shortcode_present")]
        public bool? ShortcodePresent { get; set; }
    }
}
