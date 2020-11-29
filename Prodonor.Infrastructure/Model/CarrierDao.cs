using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class CarrierDao
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PriceForMile { get; set; }
        public CarrierLocationDao Location { get; set; }
//        public virtual ICollection<OrderDao> Orders { get; set; }
    }
}
