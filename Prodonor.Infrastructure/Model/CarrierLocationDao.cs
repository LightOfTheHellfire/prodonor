using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class CarrierLocationDao
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
        [ForeignKey("CarrierId")]
        public int CarrierId { get; set; }
        public CarrierDao Carrier { get; set; }
        //        public int Radius { get; set; }
        //        public int Coverage { get; set; }
    }
}
