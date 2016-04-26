using System.Collections.Generic;
using System.Threading.Tasks;

namespace HalliganTL
{
    public interface IRestService
    {
        Task<List<Role>> RefreshRolesDataAsync();
    }
}