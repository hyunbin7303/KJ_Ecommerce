using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductById(int productId);
        Task<IEnumerable<Product>> GetProductsByNameAsync(string productName);
        //Task<Product> GetProductByIdWithCategoryAsync(string productId);
        Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId);
    }
}
