using ECommerce.Core.BusinessServices;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using ECommerce.Infrastructure.Mapping;
using ECommerce.Query;
using Microsoft.AspNetCore.Authorization;

namespace ECommerceService.Controllers
{
    public class CategoryController : BaseController
    {
        private ICategoryService _categoryService = null;
        private ICategoryRepository _categoryRepository = null;

        public CategoryController(ICategoryService categoryService, ICategoryRepository categoryRepository)
        {
            _categoryService = categoryService;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Category))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IEnumerable<Category> Get()
        {
            var allCategories = _categoryRepository.GetAll();
            return allCategories;
        }
 
        [HttpGet("CategoryId")]
        public async Task<ActionResult> Get(string categoryId)
        {
            var category = await _categoryRepository.GetByIdAsync(categoryId);
            return Ok(category);
        }


        [HttpGet("CategoryId")]
        //[Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Category))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(string categoryId)
        {
            var category = _categoryService.GetCategoriesById(categoryId);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpGet("CategoryName")]
        //[Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Category))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByName(string categoryName)
        {
            var category = _categoryService.GetCategoriesByName(categoryName);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }


        [HttpGet("ParentId")]
        //[Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Category))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByParentId(string ParentId)
        {
            var category = _categoryService.GetCategoriesByParentId(ParentId);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
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

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Category> UpdateAsync([FromBody] Category category)
        {
            try
            {
                _categoryService.UpdateCategory(category);
                return Ok(category);
            }
            catch (Exception e)
            {
                //  _logger.LogWarning(e, "Unable to PUT product.");
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
