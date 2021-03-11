using ECommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductById(string productId);
        Task<IEnumerable<Product>> GetProductsByNameAsync(string productName);
        //Task<Product> GetProductByIdWithCategoryAsync(string productId);
        Task<IEnumerable<Product>> GetProduuctByCategoryAsync(int categoryId);
    }
}
