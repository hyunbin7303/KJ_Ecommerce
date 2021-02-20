using ECommerce.Domain.Models;
using ECommerce.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace ECommerceService.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ProductController : ControllerBase
    {
        private IGenericRepository<Product> _productRepository = null;
        public ProductController(IGenericRepository<Product> repo)
        {
            _productRepository = repo ?? null;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var allProducts = _productRepository.GetAll();
            return allProducts;
        }

        [HttpGet("Details")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult ProductDetails(string productId, string updateCartItemId = null)
        {
            var product =  _productRepository.GetByIdAsync(productId);
            if (product == null)
            {
                return NotFound(); 
            }
            return Ok(product);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateAsync(Product product)
        {
            if (product.Description.Contains("XYZ Widget"))
            {
                return BadRequest();
            }
             _productRepository.Insert(product);
            return CreatedAtAction(nameof(ProductDetails), new { id = product.Id }, product);
        }

    }
}
