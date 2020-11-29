using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Application.Model
{
    public class ProductCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductDto> Products { get; set; }
    }
}
