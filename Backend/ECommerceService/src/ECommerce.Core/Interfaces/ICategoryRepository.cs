using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<IEnumerable<Category>> GetCategoriesByNameAsync(string categoryName);
        Task<IEnumerable<Category>> GetCategoriesByCategoryAsync(string categoryId);
        Task<IEnumerator<Category>> GetCategoriesByParentIdAsync(string parentId);
    }
}
