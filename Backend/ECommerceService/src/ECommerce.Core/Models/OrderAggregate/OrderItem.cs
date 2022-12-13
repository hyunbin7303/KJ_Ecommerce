using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models.OrderAggregate
{
    public class OrderItem : Entity<string>
    {
        public string OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? Discount { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
