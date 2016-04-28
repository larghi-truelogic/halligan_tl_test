//
// HalliganTL.Model.CheckReport.cs: CheckReport model class.
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
    // It represents a CheckReport Json object from the server side.
    // Endpoint /api/v1/apparatus/{apparatusId}/check-reports
    // {
    //    "apparatusId": 0,
    //    "createdAt": "2016-04-27T17:49:09.599Z",
    //    "departmentId": 0,
    //    "endTime": "2016-04-27T17:49:09.599Z",
    //    "id": 0,
    //    "startTime": "2016-04-27T17:49:09.599Z",
    //    "status": "IN_PROGRESS",
    //    "userId": 0
    // }
    //</summary>

    class CheckReport
    {
        public int ApparatusId { set; get; }
        public DateTime CreatedAt { set; get; }
        public int DepartmentId { set; get; }
        public DateTime EndTime { set; get; }
        public int Id { set; get; }
        public DateTime StartTime { set; get; }
        public string Status { set; get; }
        public int UserId { set; get; }

    }
}
