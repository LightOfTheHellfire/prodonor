using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserStoreRoles> UserStoreRoles { get; set; }
        public virtual ICollection<UserCompanyRoles> UserCompanyRoles { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
