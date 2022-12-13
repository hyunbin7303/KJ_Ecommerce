using AutoMapper;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Repository;
using ECommerce.Query;
using ECommerce.Services;
using ECommerceService.Interfaces;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceService.Test.ServiceTest
{
    class ProductServiceTest
    {
        private  IProductService _productService;
        private  IProductRepository _productRepository;
        private  IImageRepository _imageRepository;
        private ICartRepository _cartRepository;
        private IVendorRepository _vendorRepository;
        private IVendorProductRepository _vendorProductRepository;
        private IMapper _mapper;
        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MainEcommerceDBContext>()
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True");

            MainEcommerceDBContext dbContext = new MainEcommerceDBContext(optionsBuilder.Options);
            _productRepository = new ProductRepository(dbContext);
            _imageRepository = new ImageRepository(dbContext);
            _vendorRepository = new VendorRepository(dbContext);
            _vendorProductRepository = new VendorProdcutRepository(dbContext);
            _mapper = null; // Need to replace this.
            _productService = new ProductService(_mapper,_productRepository, _imageRepository, _vendorRepository, _vendorProductRepository);
            _cartRepository = new CartRepository(dbContext);
        }
        [Test]
        public void GetProductsByCategoryAsync_ReturnProducts()
        {
            var products = _productService.GetProductsByCategoryId(1);
            Assert.IsNotNull(products);
        }
        [Test]
        public void GetProductsOnSale_ReturnSalesProducts()
        {
            var products = _productService.GetProductsOnSale();
            Assert.IsNotNull(products);
        }
        [Test]
        public void GetProductsByDisplayNameContains_ShouldReturn()
        {
            var products = _productService.GetProductsByDisplayNameContains("Cross");
            Assert.NotNull(products);
        }
        [Test]
        public void UpdateProduct_NormalTest()
        {
            ProductUpdateDTO updateProductDto = new ProductUpdateDTO()
            {
            };
            _productService.UpdateProduct(updateProductDto);
        }
    }
}
