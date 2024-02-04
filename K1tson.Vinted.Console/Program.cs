namespace K1tson.Vinted.Console
{

    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using K1tson.Vinted.Repository;
    using K1tson.Vinted.Repository.Models.Request;
    using K1tson.Vinted.Repository.Service;

    internal class Program
    {
        static async Task Main(string[] args)
        {


            //GetCatalogItems
            //var request = new GetCatalogItemsRequest { 
            //    SearchText = "Age of sigmar",
            //    ResultsPage = 1,
            //    ResultsPerRequest = 980,
            //    PriceFrom = 100,
            //    PriceTo = 100,
            //};
            //var t = await new VintedRepository().GetCatalogItems(request);



            //GetMemberProfile
            //var t = await new VintedRepository().GetMemberProfile(new GetUserInformationRequest { UserId = 134419501 });

            //GetMemberProfiles
            //var request = new GetMemberProfilesRequest
            //{
            //    SearchText = "ad",
            //    ResultsPage = 1,
            //    ResultsPerRequest = 980
            //};
            //var t = await new VintedRepository().GetMemberProfiles(request);

            //GetMemberProfile
            var t = await new VintedRepository().GetRootAndSubCatalogs();




            Console.WriteLine("Done");
        }
    }
}
