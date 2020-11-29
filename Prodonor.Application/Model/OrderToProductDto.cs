using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Application.Model
{
    public class OrderToProductDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
