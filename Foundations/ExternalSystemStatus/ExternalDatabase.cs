using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalSystemStatus
{

    public class ExternalDatabase
    {
        [JsonPropertyName("wc_database_version")]
        public string? WcDatabaseVersion { get; set; }

        [JsonPropertyName("database_prefix")]
        public string? DatabasePrefix { get; set; }

        [JsonPropertyName("maxmind_geoip_database")]
        public string? MaxmindGeoipDatabase { get; set; }

        [JsonPropertyName("database_tables")]
        public ExternalDatabaseTables? DatabaseTables { get; set; }
    }
}
