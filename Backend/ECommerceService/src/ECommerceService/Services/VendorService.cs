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
        public VendorService(IMapper mapper, IVendorRepository vendorRepository)
        {
            _mapper = mapper;
            _vendorRepository = vendorRepository ?? throw new ArgumentNullException(nameof(vendorRepository));
        }
        public Task<Vendor> GetVendorByProductId(int productId)
        {
            //var vendors = _vendorRepository.Get()
            throw new NotImplementedException();
        }
        public Task<List<Vendor>> GetVendorsByCustomerName(string customerName)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vendor>> GetVendorsByUser(string userAccount)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vendor>> GetVendorsOfProductName(string productName)
        {
            throw new NotImplementedException();
        }
    }
}
