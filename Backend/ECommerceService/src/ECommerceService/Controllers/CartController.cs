using ECommerce.Core.BusinessServices;
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
        [HttpPost("NewShoppingCart")]
        public async Task<Cart> NewShoppingCart()
        {
            // Get VendorId from User
            //var cart = await _cartService.NewShoppingCart(1);
            return null;
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
        //[HttpGet("GetAllCart")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Cart))]
        //public async Task<Cart> GetCartAsync(string cartId)
        //{
        //    return await _cartRepository.GetByIdAsync(cartId);
        //}



        [HttpPost("AddCartItem")]
        public async Task<ActionResult> AddCartItem(string cartId, int productId, int quantity)
        {
            //TODO Get User information.

            // Get Item Data from Product Service.
            var product = await _productService.GetProductById(productId);
            if(product == null)
            {
                return NotFound();
            }
            await _cartService.AddItemToCart(cartId, product.Id, quantity);
            return Ok();
        }

        //[HttpPut("UpdateCart")]


    }
}
