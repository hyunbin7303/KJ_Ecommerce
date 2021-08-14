using ECommerce.Core.BusinessServices;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IList<Category> GetCategoriesById(string categoryId)
        {
            var categories = _categoryRepository.GetCategoriesByCategoryAsync(categoryId).Result.ToList();
            return categories;
        }

        public IList<Category> GetCategoriesByName(string categoryName)
        {
            var categories = _categoryRepository.GetCategoriesByNameAsync(categoryName).Result.ToList();
            return categories;
        }

        public IList<Category> GetCategoriesByParentId(string parentId)
        {
            var categories = _categoryRepository.GetCategoriesByParentIdAsync(parentId).Result.ToList();
            return categories;
        }

        public Task CreateCategory(Category category)
        {
            _categoryRepository.InsertAsync(category);
            return Task.CompletedTask;
        }

        public Task UpdateCategory(Category category)
        {
            var _category = _categoryRepository.GetByIdAsync(category.Id);
            if (_category != null)
            {
                _categoryRepository.UpdateAsync(category);
                return Task.CompletedTask;
            }
            return Task.FromResult(false);
        }

        public Task<bool> DeleteCategory(string categoryId)
        {
            var _category = _categoryRepository.GetByIdAsync(categoryId);
            if (_category != null)
            {
                var check = _categoryRepository.DeleteAsync(categoryId);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}
