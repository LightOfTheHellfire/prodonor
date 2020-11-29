using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class CompanyRolesDao
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
        public RoleDao Role { get; set; }
        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        public CompanyDao Company { get; set; }
        public virtual ICollection<UserCompanyRolesDao> UserCompanyRoles { get; set; }
    }
}
