using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class CompanyRoles
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int CompanyId { get; set; }
        public virtual ICollection<UserCompanyRoles> UserCompanyRoles { get; set; }
    }
}
