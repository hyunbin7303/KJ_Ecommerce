using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace ECommerceService.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : BaseController
    {
        private ICategoryRepository _categoryRepository = null;
        //private IProductRepository _productRepository = null;
        public CategoryController(ICategoryRepository categoryRepo, IProductRepository productRepo)
        {
            this._categoryRepository = categoryRepo;
            //this._productRepository = productRepo;
        }
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            var allCategories = _categoryRepository.GetAll();
            return allCategories;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Product> CreateAsync(Category category)
        {
            try
            {
                //if (category.Name.Contains("XYZ Widget"))
                //{
                //    return BadRequest();
                //}
                _categoryRepository.InsertAsync(category);
                return CreatedAtAction(nameof(Category), new { id = category.Id }, category);

            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }

        [HttpDelete("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Category))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteAsync(int Id)
        {
            try
            {
                await _categoryRepository.DeleteAsync(Id);
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
