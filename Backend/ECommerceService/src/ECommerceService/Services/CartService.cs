﻿using Ardalis.GuardClauses;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.CartAggregate;
using ECommerce.Core.Models.OrderAggregate;
using ECommerce.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ECommerce.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly ICartItemRepository _cartItemRepository;
        public CartService(ICartRepository cartRepository, ICartItemRepository cartItemRepository)
        {
            _cartRepository = cartRepository;
            _cartItemRepository = cartItemRepository;
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

        public async Task<IList<Cart>> GetActiveCarts(string customerId)
        {
            return await _cartRepository.Query().Include(x => x.CartItems).Where(x => x.CustomerId == customerId && x.CartActive).ToListAsync();
        }
        public async Task<IList<CartItem>> GetCartItemsByCartId(string cartId)
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
        // Sending Cart information to other service(external).
        public Task TransferBasket(string cartId, string userId)
        {
            throw new NotImplementedException();
        }
        public async Task ActivateCart(string cartId)
        {
            var cart = await _cartRepository.GetByIdAsync(cartId);
            if(cart!= null)
            {
                cart.CartActive = true;
            }
        }
        public Task<Cart> GetActiveCartCurrent(string customerId)
        {
            throw new NotImplementedException();
        }
    }
}
