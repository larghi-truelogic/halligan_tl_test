//
// HalliganTL.Model.ApparatusCheckStep.cs: ApparatusCheckStep model class.
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
    //<summary>
    // It represents a ApparatusCheckStep Json object from the server side.
    // Endpoint /api/v1/apparatus/{apparatusId}/checks
    //[
    //  {
    //    "category": "string",
    //    "createdAt": "2016-04-27T17:49:09.484Z",
    //    "description": "string",
    //    "id": 0,
    //    "name": "string",
    //    "weight": 0
    //  }
    //]
    //</summary>
    class ApparatusCheckStep
    {
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("weight")]
        public int Weight { get; set; }
    }
}
