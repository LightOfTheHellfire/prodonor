using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Application.Model
{
    public class DeliveryDto
    {
        public int Id { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int OrderId { get; set; }
    }
}
