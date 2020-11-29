using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class StoreRolesDao
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
        public RoleDao Role { get; set; }
        [ForeignKey("StoreId")]
        public int StoreId { get; set; }
        public StoreDao Store { get; set; }
        public virtual ICollection<UserStoreRolesDao> UserStoreRoles { get; set; }
    }
}
