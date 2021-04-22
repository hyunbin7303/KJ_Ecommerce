using ECommerce.Domain.Models;
using ECommerce.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(MainEcommerceDBContext context) : base(context)
        {
        }
        public async Task<Product> GetProductById(string productId)
        {
            var product = await GetByIdAsync(productId);
            return product;
        }
        public Task<IEnumerable<Product>> GetProductsAsync()
        {
            var products = GetAll();
            return Task.FromResult(products);
        }
        public Task<IEnumerable<Product>> GetProductsByNameAsync(string productName)
        {
            Expression<Func<Product, bool>> expressionProduct = x => x.Name == productName;
            var check = Get(expressionProduct);
            return Task.FromResult(check);
        }
        public Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId)
        {
            Expression<Func<Product, bool>> expressionCategory = x => x.CategoryId == categoryId;
            var check = Get(expressionCategory);
            return Task.FromResult(check);
        }
    }
}
