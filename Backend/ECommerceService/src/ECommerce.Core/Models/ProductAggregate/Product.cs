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
            ProductAttributes = new List<ProductAttribute>();
        }
        public string Name { get; private set; }
        public string DisplayName { get; private set; }
        public string Description { get; set; }
        public int VendorId { get; private set; }
        public int? CategoryId { get; private set; }
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

        // Read this later : https://www.omnicalculator.com/finance/discount#discount-formula
        public double PriceAfterDiscount()
        {
            if(Discount.HasValue && DiscountAvailable)
            {
                var discountedPrice = UnitPrice - (UnitPrice * (Discount / 100));
                return discountedPrice.Value;
            }
            return UnitPrice.Value;
        }
    }
}
