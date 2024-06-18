using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.Orders
{
    public class ExternalBilling
    {
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        [JsonPropertyName("company")]
        public string? Company { get; set; }

        [JsonPropertyName("address_1")]
        public string? Address1 { get; set; }

        [JsonPropertyName("address_2")]
        public string? Address2 { get; set; }

        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("postcode")]
        public string? Postcode { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
    }
}
