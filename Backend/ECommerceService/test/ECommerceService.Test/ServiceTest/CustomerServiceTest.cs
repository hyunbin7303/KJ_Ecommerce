using ECommerce.Core.Interfaces;
using ECommerce.Core.Services;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceService.Test.ServiceTest
{
    class CustomerServiceTest
    {

        private  ICustomerService _customerService;
        private  ICustomerRepository _customerRepository;

        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MainEcommerceDBContext>()
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            MainEcommerceDBContext dbContext = new MainEcommerceDBContext(optionsBuilder.Options);
            _customerRepository = new CustomerRepository(dbContext);
            _customerService = new CustomerService(_customerRepository);
        }

        [Test]
        [TestCase("Julio Rivas")]
        [TestCase("Kevin Park")]
        [TestCase("Evan")]
        public void GetCustomerAddrTest(string customerId)
        {
            var test = _customerService.GetAddressByCustomerId(customerId);
            Assert.IsNotNull(test);
        }

    }
}
