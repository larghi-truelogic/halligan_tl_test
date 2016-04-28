//
// HalliganTL.Data.HalliganCredential.cs: Used to serialize the user login data when we send a request to the /authorize
// endpoint.
//
// Author:
//   Agustin Larghi (agustin.larghi@truelogic.software.com)
//
using Newtonsoft.Json;

namespace HalliganTL
{
    internal class HalliganCredential
    {
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}