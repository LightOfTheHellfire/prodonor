using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class Carrier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PriceForMile { get; set; }
        public CarrierLocation Location { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
