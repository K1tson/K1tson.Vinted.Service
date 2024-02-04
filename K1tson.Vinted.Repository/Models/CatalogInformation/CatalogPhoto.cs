namespace K1tson.Vinted.Repository.Models.CatalogInformation
{
    public class CatalogPhoto
    {
        public string? Url { get; set; }
        public IEnumerable<Thumbnail>? Thumbnails { get; set; }
    }
}
