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

namespace ECommerceService.Test.RepositoryTest
{
    public class CartRepositoryTest
    {
        private ICartRepository _cartRepository;
        private ICartItemRepository _cartitemRepository;
        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MainEcommerceDBContext>()
                    .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True");
           
            MainEcommerceDBContext dbContext = new MainEcommerceDBContext(optionsBuilder.Options);
            _cartRepository = new CartRepository(dbContext);
            _cartitemRepository = new CartItemRepository(dbContext);
        }
        [Test]
        public void CartGetAll_NormalTest()
        {
            var test = _cartRepository.GetAll();
            Assert.IsNotNull(test);
        }
        [Test]
        public void CartItemGetAll_NormalTest()
        {
            var test = _cartitemRepository.GetAll();
            Assert.IsNotNull(test);
        }

        [Test]
        public void GetByIdAsyncTest_FindExistingOne_CustomerIdCheck()
        {
            var test = _cartRepository.GetByIdAsync("0B3EEB90-87D3-4093-832F-E122B3DA778E").Result;
            Assert.AreEqual("Evan1234", test.CustomerId);
        }
        [Test]
        public void GetByIdAsyncTest_FailedToFind_ReturnErrorMessage()
        {
            var test = _cartRepository.GetByIdAsync("Invalid").Result;
            Assert.AreEqual("Evan1234", test.CustomerId);
        }

        [Test]
        public void DeleteCart()
        {
            var test = _cartitemRepository.GetByIdAsync("");

        }
    }
}
