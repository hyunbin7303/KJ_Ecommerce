﻿using ECommerce.Core.BusinessServices;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.CartAggregate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Controllers
{
    public class CartController : BaseController
    {
        private readonly ICartService _cartService;
        private readonly ICartRepository _cartRepository;
        private readonly IProductService _productService;
        public CartController(ICartRepository cartRepository,IProductService productService, ICartService cartService)
        {
            _cartRepository = cartRepository;
            _cartService = cartService;
            _productService = productService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Cart))]
        public IEnumerable<Cart> Get()
        {
           return _cartRepository.GetAll();
        }

        [HttpGet("GetCart")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Cart))]
        public async Task<Cart> GetCartAsync(string cartId)
        {
            return await _cartRepository.GetByIdAsync(cartId);
        }
        [HttpGet("CartItem")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Cart))]
        public async Task<ActionResult> GetCartItemsByCartId(string cartId)
        {
            var cartItems =  _cartService.GetCartItemByCartId(cartId).Result;
            return Ok(cartItems);
        }
        [HttpPost("NewShoppingCart")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Cart))]
        public async Task<Cart> NewShoppingCart(string userId)
        {
            // Get VendorId from User
            int randomVendorId = 1;
            var cart = _cartService.newShoppingCart(userId, randomVendorId);
            return null;
        }

        [HttpPost("AddCartItem")]
        public async Task<ActionResult> AddCartItem(string cartId, int productId, int quantity)
        {
            await _cartService.AddItemToCart(cartId, productId, quantity);
            return Ok();
        }
        [HttpPut("RemoveCartItem")]
        public async Task<ActionResult> RemoveCartItem(string cartId, string cartItemId)
        {
            await _cartService.RemoveItemFromCart(cartId,cartItemId);
            return Ok();
        }
        [HttpDelete]
        public  async Task<ActionResult> Delete(string cartId)
        {
            _cartRepository.DeleteAsync(cartId);
            return Ok();
        }

    }
}
