using System;
using System.Collections.Generic;

namespace HalliganTL
{
    public class Role
    {
        public string CreatedAt { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public string Authority { get; set; }

        public List<Permission> Permissions { get; set; }
    }
}
