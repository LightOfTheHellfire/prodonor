using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Application.Model
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public virtual ICollection<DeliveryDto> Deliveries { get; set; }
        public virtual ICollection<OrderToProductDto> OrderToProducts { get; set; }
        public int UserId { get; set; }
        public int CarrierId { get; set; }
    }
}
