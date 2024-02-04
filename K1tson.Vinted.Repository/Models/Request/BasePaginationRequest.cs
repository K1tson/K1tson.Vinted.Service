namespace K1tson.Vinted.Repository.Models.Request
{
    public class BasePaginationRequest : IPaginationRequest
    {

        public BasePaginationRequest() { }

        public required string SearchText { get; set; }

        public int ResultsPage { get; set; }

        /// <summary>
        /// Results are limited to 980 per request
        /// </summary>
        public int ResultsPerRequest { get; set; }
    }
}
