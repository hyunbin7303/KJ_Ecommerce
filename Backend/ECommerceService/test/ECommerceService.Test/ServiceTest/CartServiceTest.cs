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
        public void GetActiveCarts_NotNull()
        {
            var carts = cartService.GetActiveCarts("Evan1234").Result;
            Assert.IsNotNull(carts);
        }
        [Test]
        public void AddItemToCart_AddProduct_Success()
        {
            string cartId = "0B3EEB90-87D3-4093-832F-E122B3DA778E";
            int productId = 1;
            cartService.AddItemToCart(cartId, productId, 1);
        }
        
        [Test] 
        public void GetCartItemsByCartId_ReturnManycartItems()
        {
            var cartItems = cartService.GetCartItemsByCartId("0B3EEB90-87D3-4093-832F-E122B3DA778E").Result;        
            Assert.IsNotNull(cartItems);
        }
        [Test]
        public void newShoppingCart_CreateNewShoppingCart()
        {
            cartService.newShoppingCart("", 1);
        }
    }
}
