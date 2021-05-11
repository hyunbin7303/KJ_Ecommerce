using ECommerce.Core.BusinessServices;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.CartAggregate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Controllers
{
    public class CartController : BaseController
    {
        private readonly CartService _cartService;

        public CartController(ICartRepository cartRepository)
        {
            _cartService = new CartService(cartRepository);
        }
        [HttpPost("NewShoppingCart")]
        public async Task<Cart> NewShoppingCart()
        {
            // Get VendorId from User
            var cart = await _cartService.NewShoppingCart(1);
            return cart;
        }
        [HttpGet]
        public IEnumerable<Cart> GetCarts()
        {
            var carts = _cartService.GetAll();
            return carts;
        }

    }
}
