using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class CartItem
    {
        public int Id { get; set; }
        public string CartId { get; set; }
        public int? ProductId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
