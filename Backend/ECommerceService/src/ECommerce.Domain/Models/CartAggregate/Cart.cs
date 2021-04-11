using ECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Infrastructure.Models
{
    public class Cart : Entity
    {
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
        }

        public string Id { get; set; }
        public int CustomerId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }

        public void AddCartItem(int productId, int quantity = 1)
        {
            var item = CartItems.FirstOrDefault(i => i.ProductId == productId);
            if(item != null)
            {
                item.Quantity++;
            }
        }


    }
}
