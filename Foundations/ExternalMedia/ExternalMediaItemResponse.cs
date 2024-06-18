//using Newtonsoft.Json;

//namespace WooCommerceAPI.Models.Services.Foundations.ExternalMedia
//{

//    public class ExternalMediaItemResponse
//    {
//        [JsonProperty("id")]
//        public int Id { get; set; } = 0;

//        internal DateTime date { get; set; }

//        internal DateTime date_gmt { get; set; }

//        [JsonProperty("guid")]
//        internal Guid Guid { get; set; }

//        internal DateTime modified { get; set; }

//        internal DateTime modified_gmt { get; set; }

//        [JsonProperty("slug")]
//        public string slug { get; set; }

//        public string status { get; set; }

//        public string type { get; set; }

//        public string link { get; set; }

//        [JsonProperty("title")]
//        internal Title Title { get; set; }

//        public int author { get; set; }

//        public string comment_status { get; set; }

//        public string ping_status { get; set; }

//        public string template { get; set; }

//        internal List<object> meta { get; set; }

//        public string permalink_template { get; set; }

//        public string generated_slug { get; set; }

//        internal Description description { get; set; }

//        internal Caption caption { get; set; }

//        public string alt_text { get; set; }

//        public string media_type { get; set; }

//        public string mime_type { get; set; }

//        internal MediaDetails media_details { get; set; }

//        internal object post { get; set; }

//        public string source_url { get; set; }

//        internal List<string> missing_image_sizes { get; set; }

//        internal Links _links { get; set; }
//    }


//    public class About
//    {
//        public string href { get; set; }
//    }

//    public class Author
//    {
//        public bool embeddable { get; set; }

//        public string href { get; set; }
//    }

//    public class Caption
//    {
//        public string raw { get; set; }

//        public string rendered { get; set; }
//    }

//    public class Collection
//    {
//        public string href { get; set; }
//    }

//    public class Cury
//    {
//        public string name { get; set; }

//        public string href { get; set; }

//        public bool templated { get; set; }
//    }

//    public class Description
//    {
//        public string raw { get; set; }

//        public string rendered { get; set; }
//    }

//    public class Full
//    {
//        public string file { get; set; }

//        public int width { get; set; }

//        public int height { get; set; }

//        public string mime_type { get; set; }

//        public string source_url { get; set; }
//    }

//    public class Guid
//    {
//        [JsonProperty("rendered")]
//        public string rendered { get; set; }

//        [JsonProperty("raw")]

//        public string raw { get; set; }
//    }

//    public class ImageMeta
//    {
//        public string aperture { get; set; }

//        public string credit { get; set; }

//        public string camera { get; set; }

//        public string caption { get; set; }

//        public string created_timestamp { get; set; }

//        public string copyright { get; set; }

//        public string focal_length { get; set; }

//        public string iso { get; set; }

//        public string shutter_speed { get; set; }

//        public string title { get; set; }

//        public string orientation { get; set; }

//        internal List<object> keywords { get; set; }
//    }

//    public class Links
//    {
//        internal List<Self> self { get; set; }

//        internal List<Collection> collection { get; set; }

//        internal List<About> about { get; set; }

//        internal List<Author> author { get; set; }

//        internal List<Reply> replies { get; set; }

//        [JsonProperty("wp:action-unfiltered-html")]
//        internal List<WpActionUnfilteredHtml> wpactionunfilteredhtml { get; set; }

//        [JsonProperty("wp:action-assign-author")]
//        internal List<WpActionAssignAuthor> wpactionassignauthor { get; set; }

//        internal List<Cury> curies { get; set; }
//    }

//    public class MediaDetails
//    {
//        public int width { get; set; }

//        public int height { get; set; }

//        public string file { get; set; }

//        public int filesize { get; set; }

//        internal Sizes sizes { get; set; }

//        internal ImageMeta image_meta { get; set; }
//    }

//    public class Reply
//    {
//        public bool embeddable { get; set; }

//        public string href { get; set; }
//    }

//    public class Self
//    {
//        public string href { get; set; }
//    }

//    public class Sizes
//    {
//        internal WoocommerceThumbnail woocommerce_thumbnail { get; set; }

//        internal Full full { get; set; }
//    }

//    public class Title
//    {
//        [JsonProperty("raw")]

//        public string Raw { get; set; }
//        [JsonProperty("rendered")]

//        public string Rendered { get; set; }
//    }

//    public class WoocommerceThumbnail
//    {
//        public string file { get; set; }

//        public int width { get; set; }

//        public int height { get; set; }

//        public int filesize { get; set; }

//        public bool uncropped { get; set; }

//        public string mime_type { get; set; }

//        public string source_url { get; set; }
//    }

//    public class WpActionAssignAuthor
//    {
//        public string href { get; set; }
//    }

//    public class WpActionUnfilteredHtml
//    {
//        public string href { get; set; }
//    }
//}
