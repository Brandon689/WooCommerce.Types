using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    public class ExternalImage
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonPropertyName("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonPropertyName("src")]
        public string? Src { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("alt")]
        public string? Alt { get; set; }

        public ExternalImage()
        { }

        public ExternalImage(int id)
        {
            Id = id;
        }
    }
}
