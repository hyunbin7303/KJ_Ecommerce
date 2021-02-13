using ECommerce.Domain.Models;
using ECommerce.Infrastructure;
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

        // GET api/Product/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return new Product() { Id = Guid.NewGuid().ToString(), Name = "Kevin", UnitPrice = 10.10f, Category = new Category() };
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }




    }
}
