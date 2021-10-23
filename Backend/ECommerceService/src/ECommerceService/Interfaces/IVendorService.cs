using ECommerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Interfaces
{
    public interface IVendorService
    {
        Task<Vendor> GetVendorByProductId(int productId);
        Task<List<Vendor>> GetVendorsOfProductName(string productName);
        Task<List<Vendor>> GetVendorsByCustomerName(string customerName);
        IEnumerable<Vendor> GetVendorsByDomainUser(string userAccount);
        Task<Vendor> GetVendorByName(string vendorName);
        Task<bool> CreateVendor(Vendor vendor, string userId);


    }
}
