using System.Text.Json.Serialization;
using WooCommerceAPI.Models.Services.Foundations.ExternalProducts;
using WooCommerceAPI.Models.Services.Foundations.Products;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProductVariations
{
    public class ExternalProductVariation
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

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("permalink")]
        public string? Permalink { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("price")]
        public string? Price { get; set; }

        [JsonPropertyName("regular_price")]
        public string? RegularPrice { get; set; }

        [JsonPropertyName("sale_price")]
        public string? SalePrice { get; set; }

        [JsonPropertyName("date_on_sale_from")]
        public DateTime? DateOnSaleFrom { get; set; }

        [JsonPropertyName("date_on_sale_from_gmt")]
        public DateTime? DateOnSaleFromGmt { get; set; }

        [JsonPropertyName("date_on_sale_to")]
        public DateTime? DateOnSaleTo { get; set; }

        [JsonPropertyName("date_on_sale_to_gmt")]
        public DateTime? DateOnSaleToGmt { get; set; }

        [JsonPropertyName("on_sale")]
        public bool? OnSale { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("purchasable")]
        public bool? Purchasable { get; set; }

        [JsonPropertyName("virtual")]
        public bool? Virtual { get; set; }

        [JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        //[JsonPropertyName("downloads")]
        //public List<object> Downloads { get; set; }

        [JsonPropertyName("download_limit")]
        public int? DownloadLimit { get; set; }

        [JsonPropertyName("download_expiry")]
        public int? DownloadExpiry { get; set; }

        [JsonPropertyName("tax_status")]
        public string? TaxStatus { get; set; }

        [JsonPropertyName("tax_class")]
        public string? TaxClass { get; set; }

        [JsonPropertyName("manage_stock")]
        public bool? ManageStock { get; set; }

        [JsonPropertyName("stock_quantity")]
        public int? StockQuantity { get; set; }

        [JsonPropertyName("stock_status")]
        public string? StockStatus { get; set; }

        [JsonPropertyName("backorders")]
        public string? Backorders { get; set; }

        [JsonPropertyName("backorders_allowed")]
        public bool? BackordersAllowed { get; set; }

        [JsonPropertyName("backordered")]
        public bool? Backordered { get; set; }

        [JsonPropertyName("low_stock_amount")]
        public int? LowStockAmount { get; set; }

        [JsonPropertyName("weight")]
        public string? Weight { get; set; }

        [JsonPropertyName("dimensions")]
        public Dimensions? Dimensions { get; set; }

        [JsonPropertyName("shipping_class")]
        public string? ShippingClass { get; set; }

        [JsonPropertyName("shipping_class_id")]
        public int? ShippingClassId { get; set; }

        [JsonPropertyName("image")]
        public ExternalImage? Image { get; set; }

        [JsonPropertyName("attributes")]
        public ExternalVariationAttribute[]? Attributes { get; set; }

        [JsonPropertyName("menu_order")]
        public int? MenuOrder { get; set; }

        //[JsonPropertyName("meta_data")]
        //public List<object> MetaData { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("parent_id")]
        public int? ParentId { get; set; }

        //[JsonPropertyName("_links")]
        //public Links Links { get; set; }
    }

    //public class ExternalProductVariation
    //{
    //    public string RegularPrice { get; set; } = string.Empty;

    //    public string Sku { get; set; } = string.Empty;

    //    public ProductVariationAttribute[] Attributes { get; set; }

    //    public ID Image { get; set; } = null;
    //}


    //public class Links
    //{
    //    public List<Self> self { get; set; }
    //    public List<Collection> collection { get; set; }
    //    public List<Up> up { get; set; }
    //}
}
