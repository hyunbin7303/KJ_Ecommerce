using ECommerce.Core.Models;
using ECommerce.Query.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Interfaces
{
    public interface IVendorService
    {
        Task<VendorDisplayDTO> GetVendorByProductId(int productId);
        Task<IEnumerable<VendorDisplayDTO>> GetVendorsOfProductName(string productName);
        Task<IEnumerable<VendorDisplayDTO>> GetVendorsByCustomerName(string customerName);
        IEnumerable<VendorDisplayDTO> GetVendorsByDomainUser(string userAccount);
        Task<VendorDisplayDTO> GetVendorByName(string vendorName);
        Task<Vendor> CreateVendor(VendorCreateDTO vendor);


    }
}
