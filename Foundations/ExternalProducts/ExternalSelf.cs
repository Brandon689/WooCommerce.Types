using Newtonsoft.Json;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ExternalSelf
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }
}
