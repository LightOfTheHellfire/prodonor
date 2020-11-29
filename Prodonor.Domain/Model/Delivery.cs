using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class Delivery
    {
        public int Id { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int OrderId { get; set; }
    }
}
