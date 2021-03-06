﻿using ECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Infrastructure.Models
{
    public class Cart : Entity
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }

        public override string Id { get; set; }
        public int CustomerId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }

        public void AddCartItem(CartItem item)
        {
            if(item != null)
            {
                CartItems.Add(item);
            }
        }

        public bool RemoveCartItem(int itemId)
        {
            var item = CartItems.FirstOrDefault(e => e.Id == itemId);
            return CartItems.Remove(item);
        }


    }
}
