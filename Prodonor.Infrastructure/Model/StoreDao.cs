using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class StoreDao
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        public CompanyDao Company { get; set; }
        public LocationDao Location { get; set; }
        public virtual ICollection<ProductDao> Products { get; set; }
        public virtual ICollection<StoreRolesDao> StoreRoles { get; set; }
    }
}
