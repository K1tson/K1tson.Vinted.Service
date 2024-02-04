namespace K1tson.Vinted.Repository.Service
{
    internal class VintedService
    {

        private readonly HttpClient? httpClient = null;
        private static readonly string VintedUrl = "https://www.vinted.co.uk/";
        private static readonly string VintedApiSlug = "api/v2/";

        public VintedService()
        {
            httpClient = new HttpClient();
        }

        internal async Task<string> GetVintedResponse(HttpMethod httpMethod, string endpoint)
        {
            var sessionCookies = await GetVintedAnonSession() ?? throw new HttpRequestException();
            var message = CreateVintedRequest(httpMethod, endpoint, sessionCookies);

            using HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(message);
            httpResponseMessage.EnsureSuccessStatusCode();

            return await httpResponseMessage.Content.ReadAsStringAsync();
        }

        private async Task<IEnumerable<string>> GetVintedAnonSession()
        {
            var requestMessage = CreateVintedRequest();

            using HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(requestMessage);
            httpResponseMessage.EnsureSuccessStatusCode();
            var sessionCookie = GetVintedAnonSessionCookies(httpResponseMessage);

            return sessionCookie;
        }

        private IEnumerable<string> GetVintedAnonSessionCookies(HttpResponseMessage httpResponseMessage)
        {
           return httpResponseMessage.Headers.SingleOrDefault(header => header.Key == "Set-Cookie").Value;
        }

        private HttpRequestMessage CreateVintedRequest(HttpMethod? httpMethod = null, string? endpoint = null, IEnumerable<string>? cookies = null)
        {
            var uri = endpoint == null ? new Uri(VintedUrl) : new Uri($"{VintedUrl}{VintedApiSlug}{endpoint}");
            var request = new HttpRequestMessage(httpMethod ?? HttpMethod.Get, uri);
            AddRequestHeaders(request, cookies);
            return request;
        }

        private void AddRequestHeaders(HttpRequestMessage request, IEnumerable<string>? cookies = null)
        {
            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.67 Safari/537.36");
            request.Headers.Add("Accept", "application/json, text/plain, */*");
            request.Headers.Add("Accept-Language", "en");
            request.Headers.Add("DNT", "1");
            request.Headers.Add("Connection", "keep-alive");
            request.Headers.Add("TE", "Trailers");

            if(cookies != null)
            {
                foreach (var cookie in cookies)
                {
                    request.Headers.Add("Set-Cookie", cookie);
                }
            }

        }
    }
}
