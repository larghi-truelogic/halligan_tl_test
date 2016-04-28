//
// HalliganTL.Model.ApparatusCheckStepOutcome.cs: ApparatusCheckStepOutcome model class.
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
    // It represents a ApparatusCheckStepOutcome Json object from the server side.
    // Endpoint /api/v1/check-reports/{checkReportId}/checks/{checkStepId}/outcome
    // {
    //   "apparatusCheckStep": {
    //     "category": "string",
    //     "createdAt": "2016-04-27T17:49:09.555Z",
    //     "description": "string",
    //     "id": 0,
    //     "name": "string",
    //     "weight": 0
    // },
    // "comment": "string",
    // "createdAt": "2016-04-27T17:49:09.555Z",
    // "id": 0,
    // "passing": true
    // }
    //</summary>
    class ApparatusCheckStepOutcome
    {
        [JsonProperty("apparatusCheckStep")]
        public ApparatusCheckStep ApparatusCheckStep { set; get; }
        [JsonProperty("comment")]
        public string Comment { get; set; }
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("passing")]
        public bool Passing { get; set; }
    }
}
