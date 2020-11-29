using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Application.Model
{
    public class CarrierDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PriceForMile { get; set; }
        public CarrierLocationDto Location { get; set; }
        public virtual ICollection<OrderDto> Orders { get; set; }
    }
}
