using ECommerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Interfaces
{
    public interface IVendorRepository : IGenericRepository<Vendor>
    {
        IEnumerable<Vendor> GetVendorsByDomainUser(string userDomain);
    }
}
