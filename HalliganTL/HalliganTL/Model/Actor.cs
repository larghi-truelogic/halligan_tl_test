//
// HalliganTL.Model.Actor.cs: Actor model class.
//
// Author:
//   Agustin Larghi (agustin.larghi@truelogic.software.com)
//
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalliganTL
{
    class Actor
    {
        //public List<Authorities> authorities { get; set; }
        //public ImageDerivatives imageDerivatives { get; set; }
        [JsonProperty("profileFileId")]
        public PictureFile ProfilePicture { get; set; }
        [JsonProperty("role")]
        public Role Role { get; set; }
        [JsonProperty("roleId")]
        public int RoleId { get; set; }
        [JsonProperty("status")]
        public bool Status { get; set; }
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("departmentId")]
        public int DepartmentId { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isAppAdmin")]
        public bool IsAppAdmin { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
