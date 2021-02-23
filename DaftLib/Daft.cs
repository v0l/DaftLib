using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DaftLib
{
    public class Daft
    {
        private HttpClient Client { get; }

        private string UserAgent { get; } = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.182 Safari/537.36 DaftLib/1.0";

        public const string SearchEndpoint = "https://search-gateway.dsch.ie/v1/listings";

        public const string AppVersion = "0.1.1014";

        public const string Brand = "daft";

        public const string Platform = "web";

        public const string Origin = "https://www.daft.ie";

        public Daft(string ua = null)
        {
            if(!string.IsNullOrEmpty(ua))
            {
                UserAgent = ua;
            }

            Client = new HttpClient();
            Client.DefaultRequestHeaders.Add("user-agent", UserAgent);
            Client.DefaultRequestHeaders.Add("version", AppVersion);
            Client.DefaultRequestHeaders.Add("brand", Brand);
            Client.DefaultRequestHeaders.Add("platform", Platform);
            Client.DefaultRequestHeaders.Add("orgin", Origin);
        }

        public async Task<SearchResults> Search(SearchRequest req)
        {
            return await GetResponse<SearchResults, SearchRequest>(SearchEndpoint, req);
        }

        private async Task<T> GetResponse<T, R>(string url, R requestObject = null) where R : class where T : class
        {
            var reqObj = new HttpRequestMessage(HttpMethod.Post, url);
            if (requestObject != null) 
            {
                var req = JsonSerializer.Serialize(requestObject, options: new JsonSerializerOptions()
                {
                    IgnoreNullValues = true
                });

                reqObj.Content = new ByteArrayContent(Encoding.UTF8.GetBytes(req));
                reqObj.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            } 
            else
            {
                reqObj.Method = HttpMethod.Get;
            }

            var rsp = await Client.SendAsync(reqObj);
            if(rsp.IsSuccessStatusCode)
            {
                var content = await rsp.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<T>(content);
            } 
            else
            {
                Console.WriteLine(await rsp.Content.ReadAsStringAsync());
            }

            return default;
        }
    }
}
