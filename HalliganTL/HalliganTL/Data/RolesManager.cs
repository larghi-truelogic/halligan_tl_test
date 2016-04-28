using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalliganTL
{
    public class RolesManager
    {
        IRestService restService;

        public RolesManager(IRestService service)
        {
            restService = service;
        }

        public async Task<List<Role>> GetRolesAsync()
        {
            return await restService.GetRolesDataAsync();
        }
    }
}
