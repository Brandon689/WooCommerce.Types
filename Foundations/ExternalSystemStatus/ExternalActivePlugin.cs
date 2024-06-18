using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalSystemStatus
{

    public class ExternalActivePlugin
    {
        [JsonPropertyName("plugin")]
        public string? Plugin { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("version_latest")]
        public string? VersionLatest { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("author_name")]
        public string? AuthorName { get; set; }

        [JsonPropertyName("author_url")]
        public string? AuthorUrl { get; set; }

        [JsonPropertyName("network_activated")]
        public bool? NetworkActivated { get; set; }
    }
}
