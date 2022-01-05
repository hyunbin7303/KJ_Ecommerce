using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using ECommerce.Query;
using Microsoft.AspNetCore.Authorization;
using ECommerceService.Interfaces;

namespace ECommerceService.Controllers
{
    public class ProductController : BaseController
    {
        private IProductService _productService = null;
        private IVendorService _vendorService = null;
        private IProductRepository _productRepository = null;
        // AUtomapper setting.
        public ProductController(IProductRepository repo, IProductService productService, IVendorService vendorService)
        {
            _productRepository = repo ?? null;
            _productService = productService ?? null;
            _vendorService = vendorService ?? null;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        public IEnumerable<ProductDisplayDTO> Get()
        {
            var allProducts = _productService.GetProductDisplays();
            return allProducts;
        }
        [HttpGet("GetProductByVendor")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        public IEnumerable<ProductDisplayDTO> GetProductByVendor(int vendorId)
        {
            var allProducts = _productService.GetProductsByVendorId(vendorId).Result;
            return allProducts;
        }


        [HttpGet("Details")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ProductDetails(int productId, string updateCartItemId = null)
        {
            var product =  await _productRepository.GetByIdAsync(productId);
            if (product == null)
            {
                return NotFound(); 
            }
            return Ok(product);
        }

        [HttpGet("Category")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult ProductsByCategoryId(int categoryId)
        {
            var products = _productRepository.GetProductsByCategoryAsync(categoryId);
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }
         
        [HttpGet("getsale")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ProductsGetSaleAsync()
        {
            var products = await _productService.GetProductsOnSale();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("ByNames")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ProductsByNameContains(string productName)
        {
            var products =  _productService.GetProductsByDisplayNameContains(productName);
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Product> CreateAsync([FromBody]ProductCreateDTO productDto)
        {
            try
            {
                _productService.CreateProduct(productDto);
                return CreatedAtAction(nameof(ProductDetails), new { id = productDto }, productDto);
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Product> PutProduct([FromBody]ProductUpdateDTO updateProductDto)
        {
            try
            {
                return Ok(_productService.UpdateProduct(updateProductDto));
            }
            catch (Exception e)
            {
              //  _logger.LogWarning(e, "Unable to PUT product.");
                return ValidationProblem(e.Message);
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteAsync(Product product)
        {
            try
            {
                await _productService.DeleteProduct(product.Id);
                return Ok();
            }
            catch (Exception e)
            {
                //  _logger.LogWarning(e, "Unable to Delete product.");
                return ValidationProblem(e.Message);
            }
        }
    }
}
