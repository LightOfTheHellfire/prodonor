using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class RoleDao
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StoreRolesDao> StoreRoles { get; set; }
        public virtual ICollection<CompanyRolesDao> CompanyRoles { get; set; }
    }
}
