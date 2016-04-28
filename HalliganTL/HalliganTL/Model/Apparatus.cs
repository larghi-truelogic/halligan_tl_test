//
// HalliganTL.Model.Apparatus.cs: Apparatus model class.
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
    // It represents a Apparatus Json object from the server side.
    // Endpoint /api/v1/apparatus/
    //[
    //  {
    //    "apparatusType": "string",
    //    "createdAt": "2016-04-27T17:49:09.577Z",
    //    "departmentId": 0,
    //    "id": 0,
    //    "imageDerivatives": {},
    //    "name": "string",
    //    "pictureFile": {
    //      "contentType": "string",
    //      "createdAt": "2016-04-27T17:49:09.577Z",
    //      "filesize": 0,
    //      "height": 0,
    //      "id": 0,
    //      "md5Checksum": "string",
    //      "name": "string",
    //      "width": 0
    //    }
    //  }
    //]
    class Apparatus
    {
        [JsonProperty("pictureFile")]
        public PictureFile PictureFile { get; set; }
        [JsonProperty("apparatusType")]
        public string ApparatusType { get; set; }
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty("departmentId")]
        public int DepartmentId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
