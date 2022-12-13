using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models.ProductAggregate
{
    public class ProductImage : Entity<int>
    {
        public int ProductId { get; set; }
        public int ImageId { get; set; }
    }
}
