using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalliganTL
{
    public class RequestManager
    {
        IRestService restService;

        public RequestManager(IRestService service)
        {
            restService = service;
        }

        public async Task<List<Role>> GetRolesAsync()
        {
            return await restService.GetRolesDataAsync();
        }

        public async Task GetUserAuthAsync(HalliganCredential credentials)
        {
            await restService.GetUserAuthDataAsync(credentials);
        }
    }
}
