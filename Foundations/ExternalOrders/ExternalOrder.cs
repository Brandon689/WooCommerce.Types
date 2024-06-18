using System.Text.Json.Serialization;
using WooCommerceAPI.Models.Services.Foundations.Orders;

namespace WooCommerceAPI.Models.Services.Foundations.ExternalOrders
{
    public class ExternalOrder
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("parent_id")]
        public int? ParentId { get; set; }

        [JsonPropertyName("number")]
        public string? Number { get; set; }

        [JsonPropertyName("order_key")]
        public string? OrderKey { get; set; }

        [JsonPropertyName("set_paid")]
        public string? SetPaid { get; set; }

        [JsonPropertyName("created_via")]
        public string? CreatedVia { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonPropertyName("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonPropertyName("discount_total")]
        public string? DiscountTotal { get; set; }

        [JsonPropertyName("discount_tax")]
        public string? DiscountTax { get; set; }

        [JsonPropertyName("shipping_total")]
        public string? ShippingTotal { get; set; }

        [JsonPropertyName("shipping_tax")]
        public string? ShippingTax { get; set; }

        [JsonPropertyName("cart_tax")]
        public string? CartTax { get; set; }

        [JsonPropertyName("total")]
        public string? Total { get; set; }

        [JsonPropertyName("total_tax")]
        public string? TotalTax { get; set; }

        [JsonPropertyName("prices_include_tax")]
        public bool? PricesIncludeTax { get; set; }

        [JsonPropertyName("customer_id")]
        public int? CustomerId { get; set; }

        [JsonPropertyName("customer_ip_address")]
        public string? CustomerIpAddress { get; set; }

        [JsonPropertyName("customer_user_agent")]
        public string? CustomerUserAgent { get; set; }

        [JsonPropertyName("customer_note")]
        public string? CustomerNote { get; set; }

        [JsonPropertyName("billing")]
        public ExternalBilling? Billing { get; set; }

        [JsonPropertyName("shipping")]
        public ExternalShipping? Shipping { get; set; }

        [JsonPropertyName("payment_method")]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("payment_method_title")]
        public string? PaymentMethodTitle { get; set; }

        [JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        [JsonPropertyName("date_paid")]
        public DateTime? DatePaid { get; set; }

        [JsonPropertyName("date_paid_gmt")]
        public DateTime? DatePaidGmt { get; set; }

        [JsonPropertyName("date_completed")]
        public DateTime? DateCompleted { get; set; }

        [JsonPropertyName("date_completed_gmt")]
        public DateTime? DateCompletedGmt { get; set; }

        [JsonPropertyName("cart_hash")]
        public string? CartHash { get; set; }

        //[JsonPropertyName("meta_data")]
        //public List<MetaData>? MetaData { get; set; }

        [JsonPropertyName("line_items")]
        public ExternalLineItem[]? LineItems { get; set; }

        [JsonPropertyName("tax_lines")]
        public List<ExternalTaxLine>? TaxLines { get; set; }

        [JsonPropertyName("shipping_lines")]
        public List<ExternalShippingLine>? ShippingLines { get; set; }

        [JsonPropertyName("fee_lines")]
        public List<object>? FeeLines { get; set; }

        [JsonPropertyName("coupon_lines")]
        public List<object>? CouponLines { get; set; }

        [JsonPropertyName("refunds")]
        public List<object>? Refunds { get; set; }

        //[JsonPropertyName("_links")]
        //public Links Links { get; set; }
    }
}
