using HalliganTL.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalliganTL.Service
{
    class RequestManager
    {
        public const String BaseUrl = "http://demo8743906.mockable.io/";

        public const String feedEndPoint = "feed";

        public async Task<IEnumerable<Feed>> GetFeeds()
        {
            string result = await Get(feedEndPoint);
            Feed[] feeds = null;
            var feedsToken = JObject.Parse(result)["results"];
            feeds = feedsToken.Select(feed => new Feed()
            {
                Title = (String)feed["title"],
                Description = (String)feed["description"]
            }).ToArray();
            return feeds;
        }

        private async Task<string> Get(string uri)
        {
            var client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var response = await client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsStringAsync().Result;
        }

    }
}
