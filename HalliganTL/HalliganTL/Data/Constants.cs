//
// HalliganTL.Data.Constants.cs: We store all the constants used in request related methods here.
//
// Author:
//   Agustin Larghi (agustin.larghi@truelogic.software.com)
//
using System;

namespace HalliganTL
{
    internal class Constants
    {
        //Endpoints constansts declarations
        internal static readonly string BaseAddress = "http://app.halligan.io";
        internal static readonly string AuthorizeEndpoint = "/authorize";
        internal static readonly string RolesEnpoint = "/api/v1/roles?api_key=sarasa";

        //Login credentials constants declarations
        internal static readonly string Password = "4gustinsito92!";
        internal static readonly string Username = "agustin.larghi@truelogic.software";

    }
}