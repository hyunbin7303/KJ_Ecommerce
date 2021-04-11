using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class OrderItem
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal? Quantity { get; set; }
        public string Unit { get; set; }
        public decimal? PriceUnit { get; set; }
        public decimal? Price { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
