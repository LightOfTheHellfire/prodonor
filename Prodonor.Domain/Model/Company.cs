using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
        public virtual ICollection<CompanyRoles> CompanyRoles { get; set; }
    }
}
