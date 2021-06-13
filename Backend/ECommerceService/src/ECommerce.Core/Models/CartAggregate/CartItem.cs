using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace ECommerce.Core.Models.CartAggregate
{
    public class CartItem : Entity<string>
    {
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public string CouponCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
