using ECommerce.Core.BusinessServices;
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
    class CartServiceTest
    {
        private ICartRepository cartRepository;
        private ICartItemRepository cartItemRepository;
        private ICartService cartService;
        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MainEcommerceDBContext>()
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            MainEcommerceDBContext dbContext = new MainEcommerceDBContext(optionsBuilder.Options);
            cartRepository = new CartRepository(dbContext);
            cartItemRepository = new CartItemRepository(dbContext);
            cartService = new CartService(cartRepository, cartItemRepository);
        }

        [Test]
        public void GetCartServoceActiveCart()
        {
            var carts = cartService.GetActiveCart("Evan1234").Result;
            Assert.IsNotNull(carts);
        }
    }
}
