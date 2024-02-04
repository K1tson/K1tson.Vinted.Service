using K1tson.Vinted.Repository.Models.Request;
using K1tson.Vinted.Repository.Models.Response;
using K1tson.Vinted.Repository.Service;
using K1tson.Vinted.Repository.Util;
using System.Text.Json;
using System.Web;

namespace K1tson.Vinted.Repository
{
    public class VintedRepository
    {
        private readonly VintedService _service;

        public VintedRepository() => _service = new VintedService();

        /// <summary>
        /// Get catalog items using search and various other request params.
        /// *Results per request limited to 980*
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<GetCatalogItemsResult> GetCatalogItems(GetCatalogItemsRequest request)
        {
            var searchTextEncoded = HttpUtility.UrlEncode(request.SearchText);
            var pageNumber = request.ResultsPage;
            var resultsPerRequest = request.ResultsPerRequest > 0 && request.ResultsPerRequest < 980 ? request.ResultsPerRequest : request.ResultsPerRequest > 980 ? 980 : request.ResultsPerRequest;
            var order = VintedUtil.GetCatalogItemsOrder(request.Order);
            var urlParams = $"catalog/items?page={pageNumber}&per_page={resultsPerRequest}&search_text={searchTextEncoded}&catalog_ids=&color_ids=&brand_ids=&size_ids=&material_ids=&video_game_rating_ids=&status_ids=&order={order}";
 
            string response = await _service.GetVintedResponse(HttpMethod.Get, VintedUtil.AddCatalogItemsPriceFilter(urlParams, request)) ?? throw new HttpRequestException();
            GetCatalogItemsResult bindResult = JsonSerializer.Deserialize<GetCatalogItemsResult>(response, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            return bindResult;
        }

        /// <summary>
        /// Get member profile based of UserId
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<GetMemberProfileResult> GetMemberProfile(GetUserInformationRequest request)
        {
            var urlParams = $"users/{request.UserId}?localize=false";

            string response = await _service.GetVintedResponse(HttpMethod.Get, urlParams) ?? throw new HttpRequestException();
            GetMemberProfileResult bindResult = JsonSerializer.Deserialize<GetMemberProfileResult>(response, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            return bindResult;
        }

        /// <summary>
        /// Get member profiles using search and various other request params.
        /// *Results per request limited to 90*
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<GetMemberProfilesResult> GetMemberProfiles(GetMemberProfilesRequest request)
        {
            var urlParams = $"users?page={request.ResultsPage}&per_page={request.ResultsPerRequest}&search_text={request.SearchText}";

            string response = await _service.GetVintedResponse(HttpMethod.Get, urlParams) ?? throw new HttpRequestException();
            GetMemberProfilesResult bindResult = JsonSerializer.Deserialize<GetMemberProfilesResult>(response, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            return bindResult;
        }


        /// <summary>
        /// Get all catalogs and sub catalog categories e.g. Women, Men, Kids, Home etc...
        /// </summary>
        /// <param name="catalogId"></param>
        /// <returns></returns>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<GetCatalogResponse> GetRootAndSubCatalogs(int? catalogId = null)
        {
            var urlParams = $"catalog/initializers?catalog[]={catalogId}";

            string response = await _service.GetVintedResponse(HttpMethod.Get, urlParams) ?? throw new HttpRequestException();
            GetCatalogResponse bindResult = JsonSerializer.Deserialize<GetCatalogResponse>(response, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            return bindResult;
        }



    }
}
