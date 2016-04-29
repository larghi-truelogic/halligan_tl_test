//
// HalliganTL.Data.IRestService.cs: Interface that contains every method used to request the server API
// endpoints.
//
// Author:
//   Agustin Larghi (agustin.larghi@truelogic.software.com)
//

using System.Collections.Generic;
using System.Threading.Tasks;

namespace HalliganTL
{
    public interface IRestService
    {
        Task<List<Role>> GetRolesDataAsync();
        Task GetUserAuthDataAsync(HalliganCredential credentials);
    }
}