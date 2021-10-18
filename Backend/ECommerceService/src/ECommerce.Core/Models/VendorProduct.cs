using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Models
{
    public class VendorProduct
    {
        public int VendorId { get; set; }
        public int ProductId { get; set; }
        public Vendor Vendor { get; set; }
        public Product Product { get; set; }
    }
}
