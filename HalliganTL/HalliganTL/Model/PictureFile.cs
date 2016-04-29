//
// HalliganTL.Model.PictureFile.cs: PictureFile model class.
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
    //  {
    //      "contentType": "string",
    //      "createdAt": "2016-04-27T17:49:09.577Z",
    //      "filesize": 0,
    //      "height": 0,
    //      "id": 0,
    //      "md5Checksum": "string",
    //      "name": "string",
    //      "width": 0
    //  }
    //</summary>
    class PictureFile
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty("filesize")]
        public int Filesize { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("md5Checksum")]
        public string Md5Checksum { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}
