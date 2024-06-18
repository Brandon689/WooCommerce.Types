using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.Orders
{
    public class Self
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }
    }
}
