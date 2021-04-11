using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
        }

        public string Id { get; set; }
        public int CustomerId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
