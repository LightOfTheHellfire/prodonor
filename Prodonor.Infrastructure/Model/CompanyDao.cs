using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class CompanyDao
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StoreDao> Stores { get; set; }
        public virtual ICollection<CompanyRolesDao> CompanyRoles { get; set; }
    }
}
