using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class UserCompanyRoles
    {
        public int Id { get; set; }
        public int CompanyRolesId { get; set; }
        public int UserId { get; set; }
    }
}
