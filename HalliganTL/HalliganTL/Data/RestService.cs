using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net;

namespace HalliganTL
{
    public class RestService : IRestService
    {
        HttpClient client;
        HttpClientHandler handler;
        CookieContainer cookies;
        string authToken;

        public List<Role> RolesItems { get; private set; }

        public RestService()
        {
            cookies = new CookieContainer();
            handler = new HttpClientHandler();
            handler.UseCookies = true; //Otherwise It'll not use the cookies container!!
            handler.CookieContainer = cookies;
            client = new HttpClient(handler);
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<List<Role>> RefreshRolesDataAsync()
        {
            //Request credentials
            //TODO Refactor this
            //Credentials validation
            var credentials = new HalliganCredential()
            {
                email = Constants.Username,
                password = Constants.Password
            };
            var jsonCredentials = JsonConvert.SerializeObject(credentials);
            var jsonCredentialsContent = new StringContent(jsonCredentials, Encoding.UTF8, "application/json");
            var authorizeUri = new Uri(Constants.AuthorizeEndpoint);
            var authorizeResponse = await client.PostAsync(authorizeUri, jsonCredentialsContent);
            if (authorizeResponse.IsSuccessStatusCode)
            {
                //If authentication went OK
                IEnumerable<Cookie> responseCookies = cookies.GetCookies(authorizeUri).Cast<Cookie>();
                foreach (Cookie cookie in responseCookies)
                {
                    if (cookie.Name.Equals("AUTH-TOKEN"))
                    {
                        authToken = cookie.Value;
                    }
                }
            }
            else
            {
                //Authentication failed throw error
                throw new HttpRequestException("Authentication failed");
            }


            RolesItems = new List<Role>();
            
            //Making the GET request
            
            // TODO We're actually hitting http://app.halligan.io/api/v1/roles?api_key=sarasa
            var uri = new Uri(string.Format(Constants.FeedEnpoint, string.Empty));
            try
            {
                cookies.Add(uri, new Cookie("Cookie", string.Format("AUTH_TOKEN={0}", authToken)));
                client.DefaultRequestHeaders.Add("Cookie", string.Format("AUTH_TOKEN={0}", authToken));
                handler.CookieContainer.Add(uri, new Cookie("Cookie", string.Format("AUTH_TOKEN={0}", authToken)));
                
                var response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                //Credentials validation
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    RolesItems = JsonConvert.DeserializeObject<List<Role>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }


            return RolesItems;
        }
    }
}
