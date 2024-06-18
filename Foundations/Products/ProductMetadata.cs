using Newtonsoft.Json;

namespace WooCommerceAPI.Models.Services.Foundations.Products
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ProductMetadata
    {
        public int? Id { get; set; }

        public string? Key { get; set; }

        public object? Value { get; set; }
    }
}
