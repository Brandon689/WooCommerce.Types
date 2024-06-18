using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProductVariations
{
    public class ExternalProductVariationsRequest
    {
        [JsonPropertyName("create")]
        public ExternalProductVariation[] Create { get; set; }
    }

    //public class ExternalProductVariation
    //{
    //    [JsonPropertyName("regular_price")]
    //    public string RegularPrice { get; set; } = string.Empty;

    //    [JsonPropertyName("attributes")]
    //    public ExternalProductVariationAttribute[] Attributes { get; set; }

    //    [JsonPropertyName("image")]
    //    public ExternalID Image { get; set; } = null;
    //}

    //public class ExternalProductVariationAttribute
    //{
    //    [JsonPropertyName("id")]
    //    public int Id { get; set; } = 0;

    //    [JsonPropertyName("name")]
    //    public string Name { get; set; } = string.Empty;

    //    [JsonPropertyName("option")]
    //    public string Option { get; set; } = string.Empty;
    //}
}
