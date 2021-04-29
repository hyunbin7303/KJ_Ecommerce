using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models.CartAggregate
{
    public class CartItem : Entity<string>
    {
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
    }
}
