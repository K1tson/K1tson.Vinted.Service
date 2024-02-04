using System.Text.Json.Serialization;

namespace K1tson.Vinted.Repository.Models.CatalogInformation
{
    public class CatalogInformation
    {

        public required double Id { get; set; }

        public required string Title { get; set; }

        public required string Code { get; set; }

        [JsonPropertyName("Item_Count")]
        public double ItemCount { get; set; }

        public CatalogPhoto? Photo { get; set; }

        [JsonPropertyName("Catalogs")]
        public IEnumerable<CatalogInformation>? SubCatalogs { get; set; }

    }
}
