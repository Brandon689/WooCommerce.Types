using System.Text.Json.Serialization;
using WooCommerceAPI.Models.Services.Foundations.ExternalProducts;
using WooCommerceAPI.Models.Services.Foundations.Orders;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalCustomers
{
    public class ExternalCustomer
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonPropertyName("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        [JsonPropertyName("role")]
        public string? Role { get; set; }

        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("billing")]
        public ExternalBilling? Billing { get; set; }

        [JsonPropertyName("shipping")]
        public ExternalShipping? Shipping { get; set; }

        [JsonPropertyName("is_paying_customer")]
        public bool? IsPayingCustomer { get; set; }

        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        [JsonPropertyName("meta_data")]
        public List<ExternalProductMetadata>? MetaData { get; set; }

        [JsonPropertyName("_links")]
        public ExternalLinks? Links { get; set; }
    }
}
