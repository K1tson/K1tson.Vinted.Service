namespace K1tson.Vinted.Repository.Models.Response
{
    public class GetCatalogItemsResult : BasePaginationResponse
    {
        public IEnumerable<Item>? Items { get; set; }
    }
}
