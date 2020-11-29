using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Application.Model
{
    public class CompanyRolesDto
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int CompanyId { get; set; }
        public virtual ICollection<UserCompanyRolesDto> UserCompanyRoles { get; set; }
    }
}
