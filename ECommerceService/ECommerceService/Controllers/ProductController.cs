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
        //private readonly IProductService _productService;
        private IGenericRepository<Product> _productRepository = null;

        public ProductController()
        {
        }
        //public ProductController(IGenericRepository<Product> repo)
        //{
        //    _productRepository = repo ?? null;
        //}

        [HttpGet]
        public IEnumerable<Product> Get()
        {

            using (var context = new MainEcommerceDBContext())
            {
                return context.Products.ToList();
            }
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


    }
}
