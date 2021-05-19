using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MainEcommerceDBContext context) : base(context)
        {
        }
        public async Task<Category> GetCategoryById(int categoryId)
        {
            var category = await GetByIdAsync(categoryId);
            return category;
        }
        public Task<IEnumerable<Category>> GetCategoryAsync()
        {
            var categories = GetAll();
            return Task.FromResult(categories);
        }
        public Task<IEnumerable<Category>> GetCategoryByNameAsync(string categoryName)
        {
            Expression<Func<Category, bool>> expressionCategory = x => x.Name == categoryName;
            var check = Get(expressionCategory);
            return Task.FromResult(check);
        }


    }
}
