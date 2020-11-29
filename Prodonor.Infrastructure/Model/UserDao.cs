using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class UserDao
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public virtual ICollection<OrderDao> Orders { get; set; }
        public virtual ICollection<UserStoreRolesDao> UserStoreRoles { get; set; }
        public virtual ICollection<UserCompanyRolesDao> UserCompanyRoles { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
