using ECommerce.Core.BusinessServices;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IImageRepository _imageRepository;


        public ProductService(IProductRepository orderRepository, IImageRepository imageRepository)
        {
            _productRepository = orderRepository;
            _imageRepository = imageRepository;
        }

        public Task CreateProduct(Product product)
        {
            // Mapping from Create DTO to Prodcut DTO.
            _productRepository.InsertAsync(product);
            return Task.CompletedTask;
        }
        public Task<Product> GetProductById(int productId)
        { 
            var product = _productRepository.GetByIdAsync(productId).Result;
            return product != null ? Task.FromResult(product) : null;
        }
        public Task<IEnumerable<Product>> GetProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Product>> GetProductsByDisplayNameContains(string categoryName)
        {
            Expression<Func<Product, bool>> exprProd = x => x.DisplayName.Contains(categoryName);
            var products = _productRepository.Get(exprProd);
            return Task.FromResult(products);
        }
        // Geting to accept SearchDTO.
        public Task<Product> SearchProduct(/*SearchProductDTO*/)
        {
            throw new NotImplementedException();
        }
        public Task UpdateProduct(Product product)
        {
            var _product = _productRepository.GetByIdAsync(product.Id);
            if(_product!= null)
            {
                _productRepository.UpdateAsync(product);
                return Task.CompletedTask;
            }
            return Task.FromResult(false);
        }
        public Task<bool> DeleteProduct(int productId)
        {
            var product = _productRepository.DeleteAsync(productId);
            if(product!= null)
            {
                var check = _productRepository.DeleteAsync(productId);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public Task<IEnumerable<Product>> GetProductsOnSale()
        {
            throw new NotImplementedException();
        }
    }
}
