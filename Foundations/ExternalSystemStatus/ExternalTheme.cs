using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalSystemStatus
{

    public class ExternalTheme
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("version_latest")]
        public string VersionLatest { get; set; }

        [JsonPropertyName("author_url")]
        public string AuthorUrl { get; set; }

        [JsonPropertyName("is_child_theme")]
        public bool? IsChildTheme { get; set; }

        [JsonPropertyName("has_woocommerce_support")]
        public bool? HasWoocommerceSupport { get; set; }

        [JsonPropertyName("has_woocommerce_file")]
        public bool? HasWoocommerceFile { get; set; }

        [JsonPropertyName("has_outdated_templates")]
        public bool? HasOutdatedTemplates { get; set; }

        [JsonPropertyName("overrides")]
        public List<object> Overrides { get; set; }

        [JsonPropertyName("parent_name")]
        public string ParentName { get; set; }

        [JsonPropertyName("parent_version")]
        public string ParentVersion { get; set; }

        [JsonPropertyName("parent_version_latest")]
        public string ParentVersionLatest { get; set; }

        [JsonPropertyName("parent_author_url")]
        public string ParentAuthorUrl { get; set; }
    }
}
