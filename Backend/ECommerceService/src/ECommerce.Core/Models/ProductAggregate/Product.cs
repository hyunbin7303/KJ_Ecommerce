using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models.ProductAggregate
{
    public class Product : Entity<int>
    {
        public Product()
        {
            ProductAttributes = new HashSet<ProductAttribute>();
        }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public int VendorId { get; set; }
        public int? CategoryId { get; set; }
        public string ProductFormat { get; set; }
        public int? QuantityPerUnit { get; set; }
        public double? UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public double? Discount { get; set; }
        public bool OrderAvailable { get; set; }
        public bool ProductAvailable { get; set; }
        public bool DiscountAvailable { get; set; }
        public int? ImageId { get; set; }
        public string Note { get; set; }

        public virtual Category Category { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
    }
}
