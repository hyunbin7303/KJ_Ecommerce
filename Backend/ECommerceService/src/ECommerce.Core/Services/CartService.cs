using Ardalis.GuardClauses;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.CartAggregate;
using ECommerce.Core.Models.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Core.BusinessServices
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly ICartItemRepository cartItemRepository;
        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }      

        public Cart newShoppingCart(string userId, int vendorId)
        {

            var cart = new Cart()
            {
                Id = Guid.NewGuid().ToString(),
                VendorId = vendorId,
            };
            _cartRepository.InsertAsync(cart);
            return cart;
        }
        public async Task AddItemToCart(string cartId, int productId, int quantity = 1)
        {
            var cart = await _cartRepository.GetByIdAsync(cartId);
            if(cart == null)
            {
                // return something bad return.
            }
            cart.AddCartItem(productId, quantity);
            _cartRepository.UpdateAsync(cart);
        }

        public async Task RemoveItemFromCart(string cartId, string itemId)
        {
            var cart = await _cartRepository.GetByIdAsync(cartId);
            cart.RemoveCartItem(itemId);
            _cartRepository.UpdateAsync(cart);
        }

        // Sending Cart information to other service(external).
        public Task TransferBasket(string cartId, string userId)
        {
            throw new NotImplementedException();
        }
        public async Task<IList<CartItem>> GetCartItemByCartId(string cartId)
        {
            List<CartItem> cartItems = new List<CartItem>();
            var cart = await _cartRepository.GetByIdAsync(cartId);
            if(cart == null)
            {
                return null;
            }
            cartItems = cart.CartItems.ToList();
            return cartItems;
        }
        public Task SetQuantities(string cartId, Dictionary<string, int> quantities)
        {
            throw new NotImplementedException();
        }


    }
}
