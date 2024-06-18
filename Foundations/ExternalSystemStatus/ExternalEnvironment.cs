using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalSystemStatus
{

    public class ExternalEnvironment
    {
        [JsonPropertyName("home_url")]
        public string? HomeUrl { get; set; }

        [JsonPropertyName("site_url")]
        public string? SiteUrl { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("log_directory")]
        public string? LogDirectory { get; set; }

        [JsonPropertyName("log_directory_writable")]
        public bool? LogDirectoryWritable { get; set; }

        [JsonPropertyName("wp_version")]
        public string? WpVersion { get; set; }

        [JsonPropertyName("wp_multisite")]
        public bool? WpMultisite { get; set; }

        [JsonPropertyName("wp_memory_limit")]
        public int? WpMemoryLimit { get; set; }

        [JsonPropertyName("wp_debug_mode")]
        public bool? WpDebugMode { get; set; }

        [JsonPropertyName("wp_cron")]
        public bool? WpCron { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("server_info")]
        public string? ServerInfo { get; set; }

        [JsonPropertyName("php_version")]
        public string? PhpVersion { get; set; }

        [JsonPropertyName("php_post_max_size")]
        public int? PhpPostMaxSize { get; set; }

        [JsonPropertyName("php_max_execution_time")]
        public int? PhpMaxExecutionTime { get; set; }

        [JsonPropertyName("php_max_input_vars")]
        public int? PhpMaxInputVars { get; set; }

        [JsonPropertyName("curl_version")]
        public string? CurlVersion { get; set; }

        [JsonPropertyName("suhosin_installed")]
        public bool? SuhosinInstalled { get; set; }

        [JsonPropertyName("max_upload_size")]
        public int? MaxUploadSize { get; set; }

        [JsonPropertyName("mysql_version")]
        public string? MysqlVersion { get; set; }

        [JsonPropertyName("default_timezone")]
        public string? DefaultTimezone { get; set; }

        [JsonPropertyName("fsockopen_or_curl_enabled")]
        public bool? FsockopenOrCurlEnabled { get; set; }

        [JsonPropertyName("soapclient_enabled")]
        public bool? SoapclientEnabled { get; set; }

        [JsonPropertyName("domdocument_enabled")]
        public bool? DomdocumentEnabled { get; set; }

        [JsonPropertyName("gzip_enabled")]
        public bool? GzipEnabled { get; set; }

        [JsonPropertyName("mbstring_enabled")]
        public bool? MbstringEnabled { get; set; }

        [JsonPropertyName("remote_post_successful")]
        public bool? RemotePostSuccessful { get; set; }

        [JsonPropertyName("remote_post_response")]
        public string? RemotePostResponse { get; set; }

        [JsonPropertyName("remote_get_successful")]
        public bool? RemoteGetSuccessful { get; set; }

        [JsonPropertyName("remote_get_response")]
        public string? RemoteGetResponse { get; set; }
    }
}
