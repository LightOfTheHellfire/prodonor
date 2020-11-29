using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }
        public virtual ICollection<OrderToProduct> OrderToProducts { get; set; }
        public int UserId { get; set; }
        public int CarrierId { get; set; }
    }
}
