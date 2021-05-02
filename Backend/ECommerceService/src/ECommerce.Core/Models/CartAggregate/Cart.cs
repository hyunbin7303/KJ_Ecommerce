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
            _cartitems = new List<CartItem>();
        }
        public int VendorId { get; set; }
        public string CustomerId { get; set; }
        public DateTimeOffset CreatedDate { get; private set; }
        public IEnumerable<CartItem> CartItems => _cartitems.ToList();
        private ICollection<CartItem> _cartitems;
        public void AddCartItem(int productId, decimal quantity)
        {
            _cartitems.Add(new CartItem { Id = Guid.NewGuid().ToString(), CartId = Id, ProductId = productId, Quantity = quantity, CreatedDate = DateTimeOffset.UtcNow }); ;
        }
        public void UpdateQauntityCartItem(string cartItemId, decimal quantity)
        {
        }
        public bool RemoveCartItem(string itemId)
        {
            var item = CartItems.FirstOrDefault(e => e.Id == itemId);
            return _cartitems.Remove(item);
        }


    }
}
