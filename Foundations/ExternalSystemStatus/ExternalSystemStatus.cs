using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalSystemStatus
{

    public class ExternalSystemStatus
    {
        [JsonPropertyName("environment")]
        public ExternalEnvironment? Environment { get; set; }

        [JsonPropertyName("database")]
        public ExternalDatabase? Database { get; set; }

        [JsonPropertyName("active_plugins")]
        public List<ExternalActivePlugin>? ActivePlugins { get; set; }

        [JsonPropertyName("theme")]
        public ExternalTheme? Theme { get; set; }

        [JsonPropertyName("settings")]
        public ExternalSettings? Settings { get; set; }

        [JsonPropertyName("security")]
        public ExternalSecurity? Security { get; set; }

        [JsonPropertyName("pages")]
        public ExternalPage[]? Pages { get; set; }
    }
}
