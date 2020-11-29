using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class StoreRoles
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int StoreId { get; set; }
        public virtual ICollection<UserStoreRoles> UserStoreRoles { get; set; }
    }
}
