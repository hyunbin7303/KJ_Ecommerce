using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressId { get; set; }
        public int? VendorId { get; set; }
        public string Description { get; set; }
    }
}
