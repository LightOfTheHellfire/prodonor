using System.Collections.Generic;

namespace Prodonor.Application.Model
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual ICollection<OrderDto> Orders { get; set; }
        public virtual ICollection<UserStoreRolesDto> UserStoreRoles { get; set; }
        public virtual ICollection<UserCompanyRolesDto> UserCompanyRoles { get; set; }
    }
}
