﻿using ECommerce.Core.BusinessServices;
using ECommerce.Core.Interfaces;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Repository;
using ECommerce.Infrastructure.Services;
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
        private ICartRepository cartRepository;
        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MainEcommerceDBContext>()
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True");

            MainEcommerceDBContext dbContext = new MainEcommerceDBContext(optionsBuilder.Options);
            _productRepository = new ProductRepository(dbContext);
            _imageRepository = new ImageRepository(dbContext);
            _productService = new ProductService(_productRepository, _imageRepository);
            cartRepository = new CartRepository(dbContext);
        }
        [Test]
        public void GetProductsByCategoryAsync_NromalTest()
        {
            var products = _productService.GetProductsByCategoryId(1).Result;
            Assert.IsNotNull(products);
        }
    }
}