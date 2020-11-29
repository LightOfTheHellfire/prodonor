using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class UserStoreRolesDao
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("StoreRolesId")]
        public int StoreRolesId { get; set; }
        public StoreRolesDao StoreRoles { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public UserDao User { get; set; }
    }
}
