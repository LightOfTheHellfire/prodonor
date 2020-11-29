using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Application.Model
{
    public class ProductDto
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<OrderToProductDto> OrderToProducts { get; set; }
    }
}
