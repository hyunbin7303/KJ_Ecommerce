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
            Users = new HashSet<User>();
            Products = new HashSet<Product>();
            VendorProducts = new HashSet<VendorProduct>();
            //UserVendors = new HashSet<UserVendor>();
        }
        public string VendorName { get; set; }
        public string DisplayName { get; set; }
        public string DomainUser { get; set; }
        public string CreateBy { get; set; }
        public string VendorType { get; set; }
        public int? AddressId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Website { get; set; }
        public string? Email { get; set; }
        public string? Note { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<VendorProduct> VendorProducts { get; set; }
        //public ICollection<UserVendor> UserVendors { get; set; }

    }
}
