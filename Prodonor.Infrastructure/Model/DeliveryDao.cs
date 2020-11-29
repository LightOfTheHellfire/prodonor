using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prodonor.Infrastructure.Model
{
    public class DeliveryDao
    {
        [Key]
        public int Id { get; set; }

        public DateTime DeliveryTime { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        [ForeignKey("OrderId")]
        public int OrderId { get; set; }

        public OrderDao Order { get; set; }
    }
}
