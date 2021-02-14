using ECommerce.Domain.Models;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet]
        public async Task<IActionResult> ProductDetails(string productId, string updateCartItemId= null)
        {
            var product = _productRepository.GetById(productId);
            if(product == null)
            {
                return BadRequest();
            }
            return Ok(product);
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }


    }
}
