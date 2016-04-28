//
// HalliganTL.Data.RestService.cs: Implementation of IRestService. This class should be used to request the server API
// endpoints.
//
// Author:
//   Agustin Larghi (agustin.larghi@truelogic.software.com)
//
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
using System.IO;

namespace HalliganTL
{
    public class RestService : IRestService
    {
        string authToken;
        DateTime tokenExpireDate;
        Uri baseAddress;

        public List<Role> RolesItems { get; private set; }

        public RestService()
        {
            baseAddress = new Uri(Constants.BaseAddress);
        }

        //<summary>
        //Returns the data from the /api/v1/roles endpoint
        //</summary>
        public async Task<List<Role>> GetRolesDataAsync()
        {
            return MakeGetRequest<List<Role>>(Constants.RolesEnpoint);
        }

        //<summary>
        // Makes a get request and deserializes the result JSON as T class objects.
        //</summary>
        //<param name="endpoint">The endpoint name i.e. "/api/v1/feed"</param>
        //<param name="auth">True if we want to seth the AUTH_TOKEN cookie. False otherwise.</param>
        private T MakeGetRequest<T>(string endpoint, bool auth = true)
        {
            ValidateAuthToken();
            var request = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress, endpoint));
            SetHeaders(request);
            if (string.IsNullOrEmpty(authToken))
            {
                throw new AuthTokenNullException();
            }
            //IDK Why the AUTH_TOKEN needs to be twice but if I put It only once the request doesn't work...
            request.Headers["Cookie"] = authToken;
            request.Method = "GET";
            HttpWebResponse response = request.GetResponseAsync().Result as HttpWebResponse;
            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                throw new HttpRequestException(string.Format("Warning expected response as 200 and got {0}", Convert.ToString(response.StatusCode)));
            }
            var reader = new StreamReader(response.GetResponseStream());
            string stringResponse = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<T>(stringResponse);
        }

        private void RefreshAuthToken()
        {
            //Credentials validation
            var credentials = new HalliganCredential()
            {
                Email = Constants.Username,
                Password = Constants.Password
            };
            var jsonCredentials = JsonConvert.SerializeObject(credentials);
            var request = (HttpWebRequest) WebRequest.Create(new Uri(baseAddress, Constants.AuthorizeEndpoint));
            request.ContentType = "application/json";
            request.Method = "POST";
            var requestStream = request.GetRequestStreamAsync().Result;
            var streamWriter = new StreamWriter(requestStream);
            streamWriter.Write(jsonCredentials);
            streamWriter.Flush();
            try
            {
                HttpWebResponse response = (HttpWebResponse) request.GetResponseAsync().Result;
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    //"Set-Cookies" is always in the fifth position
                    authToken = response.Headers["Set-Cookies"];
                }
                else
                {
                    //Authentication failed throw error
                    throw new HttpRequestException("Authentication failed");
                }
            } catch (Exception e)
            {
                Debug.WriteLine(string.Format("Warning: {0}", e.Message));
            }
        }

        //<summary>
        //Checks that the authToken field is properly set and It's updated.
        //</summary>
        private void ValidateAuthToken()
        {
            if (!TokenIsValid())
            {
                RefreshAuthToken();
            }
        }

        //<summary>
        //Checks that the authToken isn't null and the tokenExpireDate hasn't been reached.
        private bool TokenIsValid()
        {
            return !(string.IsNullOrEmpty(Convert.ToString(authToken)) || (tokenExpireDate != null && tokenExpireDate <= DateTime.Now));
        }

        //<summary>
        //Configures the headers for every request that we make
        //</summary>
        private static void SetHeaders(HttpWebRequest request)
        {
            request.Accept = "application/json";
            request.ContentType = "application/json; charset=utf-8";
            request.Headers["Pragma"] = "no-cache";
            request.Headers["Accept-Encoding"] = "gzip, deflate, sdch";
            request.Headers["Accept-Language"] = "es-419,es;q=0.8";
            request.Headers["Upgrade-Insecure-Requests"] = "1";
            request.Headers["Cache-Control"] = "no-cache";
        }

        //<summary>
        //This exception is triggered when we do a request without having the AUTH_TOKEN properly set
        //</summary>
        private class AuthTokenNullException : Exception
        {
            public AuthTokenNullException()
            {
            }

            public AuthTokenNullException(string message) : base(message)
            {
            }

            public AuthTokenNullException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }
    }
}
