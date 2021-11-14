using AutoMapper;
using ECommerce.Core.Interfaces;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Repository;
using ECommerce.Interfaces;
using ECommerce.Query;
using ECommerce.Services;
using ECommerceService.Automapper;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceService.Test.ServiceTest
{
    class UserServiceTest
    {
        private IMapper _mapper;
        private IUserService _userService;
        private  IUserRepository _userRepository;

        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MainEcommerceDBContext>()
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new UserProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            MainEcommerceDBContext dbContext = new MainEcommerceDBContext(optionsBuilder.Options);
            _userRepository = new UserRepository(dbContext);
            _userService = new UserService(_mapper,_userRepository);
        }

        [Test]
        public void CreateUserAsync_CreateuserWithExistingVendor( )
        {
            CreateUserDTO user = new CreateUserDTO
            {
                Account = "Testing123",
                FirstName = "Kevin",
                LastName = "Park",
                Address = "8 Callalala",
                Country = "Ontario",
                Email = "hyunbin7303@gmail.com",
                PhoneNumber = "519-721-5349",
                ZipCode = "N2L-4A3",
                VendorId = 0
            };

            var test = _userService.CreateUserAsync(user);
            Assert.IsNotNull(test);
        }

        [Test]
        public void UserGetUserByAccountAndVendorId_ReturnObject()
        {
            var test = _userService.UserGetUserByAccountAndVendorId("Testing123", 0);
            Assert.IsNotNull(test);
        }

    }
}
