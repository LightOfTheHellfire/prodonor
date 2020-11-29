using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Application.Model
{
    public class RoleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StoreRolesDto> StoreRoles { get; set; }
        public virtual ICollection<CompanyRolesDto> CompanyRoles { get; set; }
    }
}
