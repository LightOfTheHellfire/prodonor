using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class UserStoreRoles
    {
        public int Id { get; set; }
        public int StoreRolesId { get; set; }
        public int UserId { get; set; }
    }
}
