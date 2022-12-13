using AutoMapper;
using ECommerce.Core.Interfaces;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Repository;
using ECommerce.Query;
using ECommerce.Query.Vendor;
using ECommerce.Services;
using ECommerceService.Automapper;
using ECommerceService.Interfaces;
using ECommerceService.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceService.Test.ServiceTest
{
    class VendorServiceTest
    {
        private IVendorRepository _vendorRepository;
        private IVendorProductRepository _vendorProductRepository;
        //private IUserVendorRepository _userVendorRepository;
        private IVendorService _vendorService;
        private IMapper _mapper;
        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MainEcommerceDBContext>()
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True");
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new VendorProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
            MainEcommerceDBContext dbContext = new MainEcommerceDBContext(optionsBuilder.Options);
            _vendorRepository = new VendorRepository(dbContext);
            _vendorProductRepository = new VendorProdcutRepository(dbContext);
            //_userVendorRepository = new UserVendorRepository(dbContext);

            _vendorService = new VendorService(_mapper, _vendorRepository, _vendorProductRepository/*, _userVendorRepository*/);
        }
        [Test]
        public void GetProductsByCategoryAsync_ReturnProducts()
        {
            var products = _vendorService.GetVendorsByDomainUser("");
            Assert.IsNotNull(products);
        }
        [Test]
        public void CreateVendor_createVendorAndReturnVendorObject()
        {

            VendorCreateDTO vendorDto = new VendorCreateDTO
            {
                VendorName = "Kevin shop",
                DisplayName = "Kevin Bicycle shop",
                DomainUser = "hyunbin7303",
                PhoneNumber = "519-721-5394",
            };
            var vendor = _vendorService.CreateVendor(vendorDto);
            Assert.IsNotNull(vendor);
        }
    }
}
