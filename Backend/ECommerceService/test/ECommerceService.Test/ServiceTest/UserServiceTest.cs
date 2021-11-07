using AutoMapper;
using ECommerce.Core.Interfaces;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Repository;
using ECommerce.Interfaces;
using ECommerce.Query;
using ECommerce.Services;
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

            MainEcommerceDBContext dbContext = new MainEcommerceDBContext(optionsBuilder.Options);
            _userRepository = new UserRepository(dbContext);
            _userService = new UserService(_mapper,_userRepository);
        }

        [Test]
        public void CreateUserAsync_Createuser( )
        {
            UserCreateDTO user = new UserCreateDTO
            {
                Account = "Testing123",
                FirstName = "Kevin",
                LastName = "Park",
                Country = "Ontario",
                Email = "hyunbin7303@gmail.com",
                PhoneNumber = "519-721-5349",
                ZipCode = "N2L 4A3"
            };

            var test = _userService.CreateUserAsync(user);
            Assert.IsNotNull(test);
        }

    }
}
