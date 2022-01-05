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
            CreatedDate = DateTimeOffset.UtcNow;
            UpdatedDate = DateTimeOffset.UtcNow;
        }
        public int VendorId { get; set; }
        public string CustomerId { get; set; }
        public bool CartActive { get; set; }
        public bool CartLocked { get; set; }
        public bool CartCurrentUse { get; set; }
        public string? CartStatus { get; set; }
        public string? CartType { get; set; }
        public double? TotalPrice { get; set; }
        public DateTimeOffset CreatedDate { get; private set; }
        public DateTimeOffset UpdatedDate { get;  set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public void AddCartItem(int productId, decimal quantity)
        {
            CartItems.Add(new CartItem { Id = Guid.NewGuid().ToString(), CartId = Id, ProductId = productId, Quantity = quantity, CreatedDate = DateTimeOffset.UtcNow }); ;
        }
        public void UpdateQauntityCartItem(string cartItemId, decimal quantity)
        {
        }
        public bool RemoveCartItem(string itemId)
        {
            var item = CartItems.FirstOrDefault(e => e.Id == itemId);
            return CartItems.Remove(item);
        }


    }
}
