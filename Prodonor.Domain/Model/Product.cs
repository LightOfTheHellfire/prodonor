using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Domain.Model
{
    public class Product
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<OrderToProduct> OrderToProducts { get; set; }
    }
}
