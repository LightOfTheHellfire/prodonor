using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public Location Location { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<StoreRoles> StoreRoles { get; set; }
    }
}
