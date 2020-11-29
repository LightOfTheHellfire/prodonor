using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class OrderToProductDao
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        public OrderDao Order { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public ProductDao Product { get; set; }
    }
}
