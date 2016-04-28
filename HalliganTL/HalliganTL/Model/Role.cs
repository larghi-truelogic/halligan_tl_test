//
// HalliganTL.Model.Role.cs: Role model class.
//
// Author:
//   Agustin Larghi (agustin.larghi@truelogic.software.com)
//
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HalliganTL
{
    public class Role
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("departmentId")]
        public int DepartmentId { get; set; }
        [JsonProperty("authority")]
        public string Authority { get; set; }
        [JsonProperty("permissions")]
        public List<Permission> Permissions { get; set; }
    }
}
