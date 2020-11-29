using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class UserCompanyRolesDao
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CompanyRolesId")]
        public int CompanyRolesId { get; set; }
        public CompanyRolesDao CompanyRoles { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public UserDao User { get; set; }
    }
}
