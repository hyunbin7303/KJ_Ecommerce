using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.BusinessServices
{
    public interface IProductService
    {
        Task<IList<Product>> GetProducts();
        Task<Product> SearchProduct(); // change this code later(To get more paras)
        Task<Product> GetProductById(int productId);
        Task<IList<Product>> GetProductsByNameContains(string name);
        Task<IList<Product>> GetProductsByCategoryId(int categoryId);
        Task CreateProduct(Product product); // Change to ProductCreateDTO
        Task UpdateProduct(Product product);
        Task<bool> DeleteProduct(int productId);
    }
}
