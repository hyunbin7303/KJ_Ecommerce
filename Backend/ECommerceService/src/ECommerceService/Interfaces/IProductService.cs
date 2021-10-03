using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ECommerce.Interfaces
{
    public interface IProductService
    {
        Task<Product> SearchProduct(); // change this code later(To get more paras)
        IList<Product> GetProductsByDisplayNameContains(string name);
        IList<Product> GetProductsByCategoryId(int categoryId);
        Task<IList<Product>> GetProductsOnSale();
        Task CreateProduct(ProductCreateDTO product); 
        Task UpdateProduct(UpdateProductDTO product);
        Task<bool> DeleteProduct(int productId);
    }
}
