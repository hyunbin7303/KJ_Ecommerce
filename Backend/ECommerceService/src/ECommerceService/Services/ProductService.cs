using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Interfaces;

namespace ECommerce.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IImageRepository _imageRepository;

        public ProductService(IMapper mapper, IProductRepository productRepository, IImageRepository imageRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _imageRepository = imageRepository ?? throw new ArgumentNullException(nameof(imageRepository));
        }

        public IList<ProductDisplayDTO> GetProductDisplays()
        {
            var products = _productRepository.GetAll();
            var productDisplayDtos = _mapper.Map<List<ProductDisplayDTO>>(products);
            return productDisplayDtos;
        }

        public Task CreateProduct(ProductCreateDTO createProductDto)
        {
            var check = _productRepository.GetProductsByNameAsync(createProductDto.Name)?.Result;
            if(check!=null)
            {
                return null;
            }

            // Mapping from Create DTO to Product.
            Product product = _mapper.Map<Product>(createProductDto);
            //_productRepository.GetByI
            // Checking Vendor exists for the product.
            _productRepository.InsertAsync(product);
            return Task.CompletedTask;
        }
        public IList<Product> GetProductsByCategoryId(int categoryId)
        {
            var products = _productRepository.GetProductsByCategoryAsync(categoryId).Result.ToList();
            return products;
        }
        private IOrderedQueryable<Product> OrderingMethod(IQueryable<Product> query)
        {
            return query.OrderBy(student => student.Name);
        }
        public IList<Product> GetProductsByDisplayNameContains(string productDisplayName)
        {
            Expression<Func<Product, bool>> exprProd = x => x.DisplayName.Contains(productDisplayName);
            var products = _productRepository.Get(exprProd, OrderingMethod).ToList();
            return products;
        }
        // Geting to accept SearchDTO.
        public Task<Product> SearchProduct(/*SearchProductDTO*/)
        {
            throw new NotImplementedException();
        }
        public Task UpdateProduct(ProductUpdateDTO updateProductDto)
        {
            var _product = _productRepository.GetByIdAsync(updateProductDto.Id);
            if(_product!= null)
            {
                Product product = new Product();
                _productRepository.UpdateAsync(product);
                return Task.CompletedTask;
            }
            return Task.FromResult(false);
        }
        public Task<bool> DeleteProduct(int productId)
        {
            var product = _productRepository.GetByIdAsync(productId);
            if(product!= null)
            {
                var check = _productRepository.DeleteAsync(productId);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
        public Task<IList<Product>> GetProductsOnSale()
        {
            var products = _productRepository.GetAll();
            if(products == null)
                return null;

            var saleProducts = products.Where(p => p.ProductAvailable && p.DiscountAvailable).ToList();
            return Task.FromResult<IList<Product>>(saleProducts);
        }


    }
}
