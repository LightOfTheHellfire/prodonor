using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Application.Model
{
    public class CarrierLocationDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int CarrierId { get; set; }
    }
}
