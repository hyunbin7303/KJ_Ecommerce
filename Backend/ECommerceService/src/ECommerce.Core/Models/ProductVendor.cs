using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Models
{
    public class ProductVendor
    {
        public int ProductId { get; set; }
        public int VendorId { get; set; }
        public Product Product { get; set; }
        public Vendor Vendor { get; set; }
    }
}
