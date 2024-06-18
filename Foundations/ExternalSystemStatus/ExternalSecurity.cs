using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalSystemStatus
{

    public class ExternalSecurity
    {
        [JsonPropertyName("secure_connection")]
        public bool? SecureConnection { get; set; }

        [JsonPropertyName("hide_errors")]
        public bool? HideErrors { get; set; }
    }
}
