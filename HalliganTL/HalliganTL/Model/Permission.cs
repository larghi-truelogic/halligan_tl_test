//
// HalliganTL.Model.Permission.cs: Permission model class.
//
// Author:
//   Agustin Larghi (agustin.larghi@truelogic.software.com)
//
using Newtonsoft.Json;

namespace HalliganTL
{
    public class Permission
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("roleId")]
        public int RoleId { get; set; }
        [JsonProperty("authority")]
        public string Authority { get; set; }
    }
}