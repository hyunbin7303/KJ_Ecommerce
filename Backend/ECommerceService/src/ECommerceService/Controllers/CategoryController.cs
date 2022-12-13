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
        [HttpGet("CategoryId")]
        public async Task<ActionResult> Get(int categoryId)
        {
            var category =  await _categoryRepository.GetByIdAsync(categoryId);
            return Ok(category);
        }
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Product> CreateAsync(Category category)
        {
            try
            {
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
                return ValidationProblem(e.Message);
            }
        }


    }
}
