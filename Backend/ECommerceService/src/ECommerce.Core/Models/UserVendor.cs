using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Core.Models
{
    public class UserVendor
    {
        public string UserId { get; set; }
        public int VendorId { get; set; }
        public User User { get; set; }
        public Vendor Vendor { get; set; }
    }
}
