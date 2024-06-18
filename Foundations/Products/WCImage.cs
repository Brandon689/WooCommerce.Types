namespace WooCommerceAPI.Models.Services.Foundations.Products
{
    public class WCImage
    {
        public int Id { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateCreatedGmt { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateModifiedGmt { get; set; }

        public string? Src { get; set; }

        public string? Name { get; set; }

        public string? Alt { get; set; }
    }
}
