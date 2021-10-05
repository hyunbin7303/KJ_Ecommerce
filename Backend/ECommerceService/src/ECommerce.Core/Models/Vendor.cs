using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models
{
    public class Vendor : Entity<int>
    {
        public Vendor()
        {
            Products = new HashSet<Product>();
        }

        public string VendorName { get; set; }
        public int? AddressId { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<ProductVendor> ProductVendors { get; set; }
    }
}
