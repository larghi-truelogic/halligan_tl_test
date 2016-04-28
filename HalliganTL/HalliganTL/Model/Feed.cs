//
// HalliganTL.Model.Feed.cs: Feed model class.
//
// Author:
//   Agustin Larghi (agustin.larghi@truelogic.software.com)
//
using Newtonsoft.Json;
using System;

namespace HalliganTL
{
    //<summary>
    // It represents a Feed Json object from the server side.
    // Endpoint /api/v1/feed/
    // [
    //  {
    //    "actor": {
    //      "authorities": [
    //        {}
    //      ],
    //      "createdAt": "2016-04-27T17:49:09.631Z",
    //      "departmentId": 0,
    //      "email": "string",
    //      "firstName": "string",
    //      "id": 0,
    //      "imageDerivatives": {},
    //      "isAppAdmin": true,
    //      "lastName": "string",
    //      "password": "string",
    //      "profileFileId": {
    //        "contentType": "string",
    //        "createdAt": "2016-04-27T17:49:09.631Z",
    //        "filesize": 0,
    //        "height": 0,
    //        "id": 0,
    //        "md5Checksum": "string",
    //        "name": "string",
    //        "width": 0
    //      },
    //      "role": {
    //        "createdAt": "2016-04-27T17:49:09.631Z",
    //        "departmentId": 0,
    //        "id": 0,
    //        "name": "string",
    //        "permissions": [
    //          {
    //            "id": 0,
    //            "name": "string",
    //            "roleId": 0
    //          }
    //        ]
    //      },
    //      "roleId": 0,
    //      "status": true,
    //      "updatedAt": "2016-04-27T17:49:09.632Z",
    //      "username": "string"
    //    },
    //    "body": "string",
    //    "createdAt": "2016-04-27T17:49:09.632Z",
    //    "departmentId": 0,
    //    "entityId": 0,
    //    "entityType": "string",
    //    "id": 0
    //  }
    //]
    //</summary>
    class Feed
    {
        [JsonProperty("actor")]
        public Actor Actor { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty("departmentId")]
        public int DepartmentId { get; set; }
        [JsonProperty("entityId")]
        public int EntityId { get; set; }
        [JsonProperty("entityType")]
        public string EntityType { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
