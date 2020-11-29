using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prodonor.Infrastructure.Model
{
    public class LocationDao
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("StoreId")]
        public int StoreId { get; set; }
        public StoreDao Store { get; set; }
        public string Value { get; set; }
    }
}
