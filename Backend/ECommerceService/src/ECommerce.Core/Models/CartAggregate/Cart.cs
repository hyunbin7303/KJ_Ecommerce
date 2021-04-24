using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Core.Models.CartAggregate
{
    public class Cart : Entity<string>
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public string CustomerId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public void AddCartItem(CartItem item)
        {
            if(item != null)
            {
                CartItems.Add(item);
            }
        }
        public bool RemoveCartItem(string itemId)
        {
            var item = CartItems.FirstOrDefault(e => e.Id == itemId);
            return CartItems.Remove(item);
        }


    }
}
