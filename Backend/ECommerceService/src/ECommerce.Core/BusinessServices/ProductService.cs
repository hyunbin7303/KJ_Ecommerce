using ECommerce.Core.BusinessServices;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository orderRepository)
        {
            _productRepository = orderRepository;
        }

        public Task CreateProduct(Product product)
        {
            // Mapping from Create DTO to Prodcut DTO.
            _productRepository.Insert(product);
            return Task.CompletedTask;
        }
        public Task<Product> GetProductById(int productId)
        {
            var product = _productRepository.GetProductById(productId).Result;
            return product != null ? Task.FromResult<Product>(product) : null;
        }
        public Task<IList<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }
        public Task<IList<Product>> GetProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }
        public Task<IList<Product>> GetProductsByNameContains(string name)
        {
            throw new NotImplementedException();
        }

        // Geting to accept SearchDTO.
        public Task<Product> SearchProduct(/*SearchProductDTO*/)
        {
            throw new NotImplementedException();
        }
        public Task UpdateProduct(Product product)
        {
            var _product = _productRepository.GetProductById(product.Id);
            if(_product!= null)
            {
                _productRepository.Update(product);
                return Task.CompletedTask;
            }
            return null;

        }
        public Task<bool> DeleteProduct(int productId)
        {
            var check = _productRepository.DeleteAsync(productId); // need to define a way to return properly.
            return Task.FromResult(true);
        }

    }
}
