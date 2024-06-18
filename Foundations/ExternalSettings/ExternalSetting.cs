using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalSettings
{

    public class ExternalSetting
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("label")]
        public string? Label { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        [JsonPropertyName("sub_groups")]
        public string[]? SubGroups { get; set; }

        //[JsonPropertyName("_links")]
        //public Links Links { get; set; }
    }
}
