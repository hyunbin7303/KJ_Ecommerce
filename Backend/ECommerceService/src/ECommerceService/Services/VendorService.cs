using AutoMapper;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Query.Vendor;
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
        private IVendorRepository        _vendorRepository;
        private IVendorProductRepository _vendorProductRepository;
        private IUserVendorRepository    _userVendorRepository;

        public VendorService(IMapper mapper, IVendorRepository vendorRepository, IVendorProductRepository vendorProductRepository, IUserVendorRepository userVendorRepository)
        {
            _mapper = mapper;
            _vendorRepository = vendorRepository                ?? throw new ArgumentNullException(nameof(vendorRepository));
            _vendorProductRepository = vendorProductRepository  ?? throw new ArgumentNullException(nameof(vendorProductRepository));
            _userVendorRepository = userVendorRepository        ?? throw new ArgumentNullException(nameof(userVendorRepository));
        }

        public async Task<Vendor> CreateVendor(VendorCreateDTO vendor, string userId)
        {

            var insertVendor = _mapper.Map<Vendor>(vendor);



            var vendorInserted = _vendorRepository.InsertAsync(insertVendor);


            UserVendor userVendor = new UserVendor() { UserId = userId };
            var insertedUserVendor = await _userVendorRepository.InsertAsync(userVendor);



            return await vendorInserted;
        }

        public Task<VendorDisplayDTO> GetVendorByName(string vendorName)
        {
            throw new NotImplementedException();
        }

        public Task<VendorDisplayDTO> GetVendorByProductId(int productId)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<VendorDisplayDTO>> GetVendorsByCustomerName(string customerName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VendorDisplayDTO> GetVendorsByDomainUser(string userAccount)
        {
            var vendors = _vendorRepository.GetVendorsByDomainUser(userAccount);
            return _mapper.Map<IEnumerable<VendorDisplayDTO>>(vendors);
        }

        public Task<IEnumerable<VendorDisplayDTO>> GetVendorsOfProductName(string productName)
        {
            throw new NotImplementedException();
        }
    }
}
