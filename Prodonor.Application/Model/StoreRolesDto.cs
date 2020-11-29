using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Application.Model
{
    public class StoreRolesDto
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int StoreId { get; set; }
        public virtual ICollection<UserStoreRolesDto> UserStoreRoles { get; set; }
    }
}
