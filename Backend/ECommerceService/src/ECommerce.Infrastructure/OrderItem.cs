using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure
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
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
    }
}
