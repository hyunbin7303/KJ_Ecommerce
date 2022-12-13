using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models
{
    public class Warehouse : Entity<int>
    {
        public string Name { get; set; }
        public string AddressId { get; set; }
        public int? VendorId { get; set; }
        public string Description { get; set; }
    }
}
