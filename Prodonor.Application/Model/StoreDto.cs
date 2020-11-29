using System;
using System.Collections.Generic;
using System.Text;

namespace Prodonor.Application.Model
{
    public class StoreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public LocationDto Location { get; set; }
        public virtual ICollection<ProductDto> Products { get; set; }
        public virtual ICollection<StoreRolesDto> StoreRoles { get; set; }
    }
}
