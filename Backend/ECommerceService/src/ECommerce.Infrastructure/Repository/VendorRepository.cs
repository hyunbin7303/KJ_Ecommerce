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

        public Task<Vendor> GetByVendorName(string vendorName)
        {

            throw new NotImplementedException();
        }
    }
}
