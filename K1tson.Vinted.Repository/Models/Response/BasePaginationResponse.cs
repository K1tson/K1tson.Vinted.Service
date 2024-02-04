namespace K1tson.Vinted.Repository.Models.Response
{
    public class BasePaginationResponse : IPaginationResult
    {
        public required Pagination Pagination { get; set; }
        public required double Code { get; set; }
    }
}
