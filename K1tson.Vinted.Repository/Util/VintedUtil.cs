using K1tson.Vinted.Repository.Models;
using K1tson.Vinted.Repository.Models.Request;
using System.Text;

namespace K1tson.Vinted.Repository.Util
{
    internal class VintedUtil
    {
        internal static string GetCatalogItemsOrder(EOrder order)
        {

            return order switch
            {
                EOrder.Newest => "newest",
                EOrder.Relevance => "relevance",
                EOrder.PriceLowToHigh => "price_low_to_high",
                EOrder.PriceHighToLow => "price_high_to_low",
                _ => "",
            };
        }


        internal static string AddCatalogItemsPriceFilter(string urlParams, GetCatalogItemsRequest request)
        { 
            var sb = new StringBuilder(urlParams);

            if (request.PriceFrom != null && request.PriceTo != null)
            {
                string? priceFrom = request.PriceFrom <= request.PriceTo ? request.PriceFrom.Value.ToString() : String.Empty;
                string? priceTo = request.PriceTo >= request.PriceFrom ? request.PriceTo.Value.ToString() : String.Empty;

                if (priceFrom != string.Empty && priceTo != string.Empty)
                    sb.Append($"&price_from={priceFrom}&price_to={priceTo}");
            }

            return sb.ToString();
        }


    }
}
