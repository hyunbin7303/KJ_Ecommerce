using ECommerce.Core.BusinessServices;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.CartAggregate;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ctrl + R or ctrl + T
namespace ECommerceService.Test.RepositoryTest
{
    public class ProductRepositoryTest
    {
        private IProductRepository _productRepository;

        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MainEcommerceDBContext>()
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True");

            MainEcommerceDBContext dbContext = new MainEcommerceDBContext(optionsBuilder.Options);
            _productRepository = new ProductRepository(dbContext);
        }
        // Unit Testing
        // Unit testing is a testing method by which individual units of source code are tested to determine if they are ready to use

        // Test Get All Products
        [Test]
        public void ProductGetAll_NormalTest()
        {
            var test = _productRepository.GetAll();
            Assert.IsNotNull(test);
        }

        // Test Get Product Details
        [Test]
        public void ProductGetByIdAsync_NormalTest()
        {
            var test = _productRepository.GetByIdAsync(1).Result;
            Assert.IsNotNull(test);
        }

        // Test Get Product Details
        [Test]
        public void ProductGetByIdAsync_CheckingVendorInfo()
        {
            var test = _productRepository.GetByIdAsync(1).Result;
            Assert.AreEqual("VendorCheck", test.Vendor.VendorName);
        }

        //Integration testing checks integration between software modules
        /* Test Post Method*/
        [Test]
        public void ProductPostProduct_NormalTest()
        {
            //
        }

        // Test Get Products by Category (*ServiceTest*)
        //[Test]
        //public void ProductGetByCategory_NormalTest()
        //{
        //    var test = _productRepository.GetProductsByCategoryAsync();
        //    Assert.IsNotNull(test);
        //}
    }
}
