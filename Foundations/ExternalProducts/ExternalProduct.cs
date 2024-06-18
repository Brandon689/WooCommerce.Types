using System.Text.Json.Serialization;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalProducts
{
    public class ExternalProduct
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("slug")]
        public string? Slug { get; set; }

        [JsonPropertyName("permalink")]
        public string? Permalink { get; set; }

        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonPropertyName("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("featured")]
        public bool? Featured { get; set; }

        [JsonPropertyName("catalog_visibility")]
        public string? CatalogVisibility { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("short_description")]
        public string? ShortDescription { get; set; }

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

        [JsonPropertyName("price_html")]
        public string? PriceHtml { get; set; }

        [JsonPropertyName("on_sale")]
        public bool? OnSale { get; set; }

        [JsonPropertyName("purchasable")]
        public bool? Purchasable { get; set; }

        [JsonPropertyName("total_sales")]
        public int? TotalSales { get; set; }

        [JsonPropertyName("virtual")]
        public bool? Virtual { get; set; }

        [JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        [JsonPropertyName("downloads")]
        public object[]? Downloads { get; set; }

        [JsonPropertyName("download_limit")]
        public int? DownloadLimit { get; set; }

        [JsonPropertyName("download_expiry")]
        public int? DownloadExpiry { get; set; }

        [JsonPropertyName("external_url")]
        public string? ExternalUrl { get; set; }

        [JsonPropertyName("button_text")]
        public string? ButtonText { get; set; }

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

        [JsonPropertyName("sold_individually")]
        public bool? SoldIndividually { get; set; }

        [JsonPropertyName("weight")]
        public string? Weight { get; set; }

        [JsonPropertyName("dimensions")]
        public ExternalDimensions? Dimensions { get; set; }

        [JsonPropertyName("shipping_required")]
        public bool? ShippingRequired { get; set; }

        [JsonPropertyName("shipping_taxable")]
        public bool? ShippingTaxable { get; set; }

        [JsonPropertyName("shipping_class")]
        public string? ShippingClass { get; set; }

        [JsonPropertyName("shipping_class_id")]
        public int? ShippingClassId { get; set; }

        [JsonPropertyName("reviews_allowed")]
        public bool? ReviewsAllowed { get; set; }

        [JsonPropertyName("average_rating")]
        public string? AverageRating { get; set; }

        [JsonPropertyName("rating_count")]
        public int? RatingCount { get; set; }

        [JsonPropertyName("related_ids")]
        public int[]? RelatedIds { get; set; }

        [JsonPropertyName("upsell_ids")]
        public object[]? UpsellIds { get; set; }

        [JsonPropertyName("cross_sell_ids")]
        public object[]? CrossSellIds { get; set; }

        [JsonPropertyName("parent_id")]
        public int? ParentId { get; set; }

        [JsonPropertyName("purchase_note")]
        public string? PurchaseNote { get; set; }

        [JsonPropertyName("categories")]
        public ExternalCategory[]? Categories { get; set; }

        [JsonPropertyName("tags")]
        public ExternalTag[]? Tags { get; set; }

        [JsonPropertyName("images")]
        public ExternalImage[]? Images { get; set; }

        [JsonPropertyName("attributes")]
        public ExternalProductAttribute[]? Attributes { get; set; }

        [JsonPropertyName("default_attributes")]
        public ExternalDefaultAttribute[]? DefaultAttributes { get; set; }

        [JsonPropertyName("variations")]
        public int[]? Variations { get; set; }

        [JsonPropertyName("grouped_products")]
        public object[]? GroupedProducts { get; set; }

        [JsonPropertyName("menu_order")]
        public int? MenuOrder { get; set; }

        [JsonPropertyName("meta_data")]
        public ExternalProductMetadata[]? MetaData { get; set; }

        [JsonPropertyName("_links")]
        public ExternalLinks? Links { get; set; }
    }
}
