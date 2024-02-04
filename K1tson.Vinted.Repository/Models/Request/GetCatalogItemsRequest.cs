namespace K1tson.Vinted.Repository.Models.Request
{
    public class GetCatalogItemsRequest : BasePaginationRequest
    {
        public int? PriceFrom { get; set; }

        public int? PriceTo { get; set; }

        public EOrder Order { get; set; }
    }
}
