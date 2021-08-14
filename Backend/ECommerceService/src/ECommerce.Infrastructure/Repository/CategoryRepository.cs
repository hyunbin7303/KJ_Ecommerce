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
        public Task<IEnumerable<Category>> GetCategoriesByNameAsync(string categoryName)
        {
            Expression<Func<Category, bool>> expressionCategory = x => x.Name == categoryName;
            var categories = Get(expressionCategory);
            return Task.FromResult(categories);
        }
        public Task<IEnumerable<Category>> GetCategoriesByCategoryAsync(string categoryId)
        {
            Expression<Func<Category, bool>> expressionCategory = x => x.Id == categoryId;
            var categories = Get(expressionCategory);
            return Task.FromResult(categories);
        }
        public Task<IEnumerable<Category>> GetCategoriesByParentIdAsync(string parentId)
        {
            Expression<Func<Category, bool>> expressionCategory = x => x.ParentId == parentId;
            var categories = Get(expressionCategory);
            return Task.FromResult(categories);
        }
    }
}
