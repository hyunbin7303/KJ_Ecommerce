using AutoMapper;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerceService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Services
{
    public class VendorService : IVendorService
    {
        private IMapper _mapper;
        private IVendorRepository _vendorRepository;
        private IVendorProductRepository _vendorProductRepository;
        private IUserVendorRepository _userVendorRepository;

        public VendorService(IMapper mapper, IVendorRepository vendorRepository, IVendorProductRepository vendorProductRepository, IUserVendorRepository userVendorRepository)
        {
            _mapper = mapper;
            _vendorRepository = vendorRepository ?? throw new ArgumentNullException(nameof(vendorRepository));
            _vendorProductRepository = vendorProductRepository ?? throw new ArgumentException(nameof(vendorProductRepository));
            _userVendorRepository = userVendorRepository ?? throw new ArgumentException(nameof(userVendorRepository));

        }

        public Task<bool> CreateVendor(Vendor vendor, string userId)
        {
            UserVendor userVendor = new UserVendor() { UserId = userId, VendorId = vendor.Id };
            _userVendorRepository.InsertAsync(userVendor);

            _vendorRepository.InsertAsync(vendor);
            return Task.FromResult(true);
        }

        public Task<Vendor> GetVendorByName(string vendorName)
        {
            throw new NotImplementedException();
        }

        public Task<Vendor> GetVendorByProductId(int productId)
        {
            throw new NotImplementedException();
        }
        public Task<List<Vendor>> GetVendorsByCustomerName(string customerName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vendor> GetVendorsByDomainUser(string userAccount)
        {
            return _vendorRepository.GetVendorsByDomainUser(userAccount);
        }

        public Task<List<Vendor>> GetVendorsOfProductName(string productName)
        {
            throw new NotImplementedException();
        }
    }
}
