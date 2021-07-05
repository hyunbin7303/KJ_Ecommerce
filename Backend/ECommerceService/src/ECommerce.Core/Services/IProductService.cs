using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ECommerce.Core.BusinessServices
{
    public interface IProductService
    {
        Task<Product> SearchProduct(); // change this code later(To get more paras)
        IList<Product> GetProductsByDisplayNameContains(string name);
        IList<Product> GetProductsByCategoryId(int categoryId);
        Task<IList<Product>> GetProductsOnSale();
        Task CreateProduct(Product product); // Change to ProductCreateDTO
        Task UpdateProduct(Product product);
        Task<bool> DeleteProduct(int productId);
    }
}
