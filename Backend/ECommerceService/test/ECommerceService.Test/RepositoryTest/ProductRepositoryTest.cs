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
        [Test]
        public void ProductGetAll_NormalTest()
        {
            var test = _productRepository.GetAll();
            Assert.IsNotNull(test);
        }
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
        [Test]
        public void ProductPostProduct_NormalTest()
        {
        }

    }
}
