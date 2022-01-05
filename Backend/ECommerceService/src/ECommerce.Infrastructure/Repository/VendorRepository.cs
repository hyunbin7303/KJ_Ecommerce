using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class VendorRepository : GenericRepository<Vendor>, IVendorRepository
    {

        public VendorRepository(MainEcommerceDBContext context) : base(context)
        {
        }


        public Task<Vendor> GetVendorByVendorNameAndUserAsync(string vendorName, string domainUser)
        {
            //Expression<Func<Vendor, bool>> exprVendor = x => x.
            return null;
        }

        public IEnumerable<Vendor> GetVendorsByDomainUser(string userDomain)
        {
            Expression<Func<Vendor, bool>> exprVendor = x => x.DomainUser == userDomain;
            var vendors = Get(exprVendor);
            return vendors;
        }
    }
}
