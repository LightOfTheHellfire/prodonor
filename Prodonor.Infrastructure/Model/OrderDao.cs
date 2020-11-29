using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prodonor.Infrastructure.Model
{
    public class OrderDao
    {
        [Key]
        public int Id { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationTime { get; set; }
        public virtual ICollection<DeliveryDao> Deliveries { get; set; }
        public virtual ICollection<OrderToProductDao> OrderToProducts { get; set; }
//        [ForeignKey("UserId")]
//        public int UserId { get; set; }
//        public UserDao User { get; set; }
    }
}
