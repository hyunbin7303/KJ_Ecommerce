using ECommerce.Core.Interfaces;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceService.Test.RepositoryTest
{
    public class AddressRepositoryTest
    {
        private IAddressRepository _addressRepository;
        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MainEcommerceDBContext>()
                    .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True");

            MainEcommerceDBContext dbContext = new MainEcommerceDBContext(optionsBuilder.Options);
            _addressRepository = new AddressRepository(dbContext);
        }

        [Test]
        public void AddressGetAll_NormalTest()
        {
            var test = _addressRepository.GetAll();
            Assert.IsNotNull(test);
        }


        [Test]
        [TestCase("")]
        [TestCase("")]
        [TestCase("")]
        public void AddressGetAll_NormalTest(string customerId)
        {
            var test = _addressRepository.GetByIdAsync(customerId);
            Assert.IsNotNull(test);
        }

        


    }
}
