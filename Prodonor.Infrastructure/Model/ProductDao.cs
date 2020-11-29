using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class ProductDao
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("StoreId")]
        public int StoreId { get; set; }
        public StoreDao Store { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public ProductCategoryDao Category { get; set; }
        public virtual ICollection<OrderToProductDao> OrderToProducts { get; set; }
    }
}
