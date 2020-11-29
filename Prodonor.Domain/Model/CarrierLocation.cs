using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class CarrierLocation
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int CarrierId { get; set; }
//        public CarrierDao Carrier { get; set; }
        //        public int Radius { get; set; }
        //        public int Coverage { get; set; }
    }
}
