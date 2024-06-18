using Newtonsoft.Json;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProductVariations
{
    public class ExternalProductVariationsRequest
    {
        [JsonProperty("create")]
        public ExternalProductVariation[] Create { get; set; }
    }

    //public class ExternalProductVariation
    //{
    //    [JsonProperty("regular_price")]
    //    public string RegularPrice { get; set; } = string.Empty;

    //    [JsonProperty("attributes")]
    //    public ExternalProductVariationAttribute[] Attributes { get; set; }

    //    [JsonProperty("image")]
    //    public ExternalID Image { get; set; } = null;
    //}

    //public class ExternalProductVariationAttribute
    //{
    //    [JsonProperty("id")]
    //    public int Id { get; set; } = 0;

    //    [JsonProperty("name")]
    //    public string Name { get; set; } = string.Empty;

    //    [JsonProperty("option")]
    //    public string Option { get; set; } = string.Empty;
    //}
}
