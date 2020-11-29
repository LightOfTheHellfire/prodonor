using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class Location
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Value { get; set; }
    }
}
