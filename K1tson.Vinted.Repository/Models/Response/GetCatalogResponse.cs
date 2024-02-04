using K1tson.Vinted.Repository.Models.CatalogInformation;

namespace K1tson.Vinted.Repository.Models.Response
{
    public class GetCatalogResponse
    {
        public required CatalogDtos Dtos { get; set; }
    }
}
