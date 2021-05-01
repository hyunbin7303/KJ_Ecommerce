using Ardalis.GuardClauses;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.CartAggregate;
using ECommerce.Core.Models.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.BusinessServices
{
    public class CartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }      

        public async Task<Cart> NewShoppingCart()
        {
            var cart = new Cart()
            {
                Id = Guid.NewGuid().ToString()
            };
            _cartRepository.Insert(cart);
            return cart;
        }

        public async Task AddItemToCart(string cartId, int productId, decimal quantity)
        {
            var cart = await _cartRepository.GetByIdAsync(cartId);
            cart.AddCartItem(productId, quantity);
            _cartRepository.Update(cart);
        }

        public async Task RemoveItemFromCart(string cartId, string itemId)
        {
            var cart = await _cartRepository.GetByIdAsync(cartId);
            cart.RemoveCartItem(itemId);
            _cartRepository.Update(cart);
        }
    }
}
