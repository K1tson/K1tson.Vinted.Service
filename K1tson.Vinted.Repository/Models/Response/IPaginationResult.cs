namespace K1tson.Vinted.Repository.Models.Response
{
    public interface IPaginationResult
    {
        public Pagination Pagination { get; set; }
        public double Code { get; set; }
    }
}
