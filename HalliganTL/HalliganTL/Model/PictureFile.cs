//
// HalliganTL.Model.PictureFile.cs: PictureFile model class.
//
// Author:
//   Agustin Larghi (agustin.larghi@truelogic.software.com)
//
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
        public string contentType { get; set; }
        public string createdAt { get; set; }
        public int filesize { get; set; }
        public int height { get; set; }
        public int id { get; set; }
        public string md5Checksum { get; set; }
        public string name { get; set; }
        public int width { get; set; }
    }
}
