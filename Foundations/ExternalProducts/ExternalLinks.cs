using Newtonsoft.Json;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ExternalLinks
    {
        [JsonProperty("self")]
        public ExternalSelf[] Self { get; set; }

        [JsonProperty("collection")]
        public ExternalCollection[] Collection { get; set; }
    }
}
