﻿using ECommerce.Domain.Models;
using ECommerce.Infrastructure.Repository;
using ECommerce.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using ECommerce.Infrastructure.Mapping;

namespace ECommerceService.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ProductController : ControllerBase
    {
        //private IGenericRepository<Product> _productRepository = null;
        private IProductRepository _productRepository = null;
        

        public ProductController(IProductRepository repo)
        {
            _productRepository = repo ?? null;
        }


        [HttpGet]
        public IEnumerable<ProductDetailsDTO> Get()
        {
            var allProducts = _productRepository.GetAll();
            var mapped = ObjectMapper.Mapper.Map<IEnumerable<ProductDetailsDTO>>(allProducts);
            return mapped;
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
            var products = _productRepository.GetProductByCategoryAsync(categoryId);
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
        public ActionResult<Product> CreateAsync(Product product)
        {
            try
            {
                if (product.Description.Contains("XYZ Widget"))
                {
                    return BadRequest();
                }
                //temporary create GUID product Id
                Guid tmpId = Guid.NewGuid();
                //product.Id = tmpId.ToString();
                
                _productRepository.Insert(product);
                return CreatedAtAction(nameof(ProductDetails), new { id = product.Id }, product);

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
        public ActionResult<Product> PutProduct([FromBody] Product product)
        {
            try
            {
                _productRepository.Update(product);
                return Ok(product);
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
        public async Task DeleteAsync(Product product)
        {
            try
            {
                await _productRepository.DeleteAsync(product.Id);
            }
            catch (Exception e)
            {
                //  _logger.LogWarning(e, "Unable to Delete product.");
            }
        }
    }
}
