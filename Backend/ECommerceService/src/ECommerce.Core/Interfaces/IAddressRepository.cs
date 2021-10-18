using ECommerce.Core.Models;
using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Interfaces
{
    public interface IAddressRepository : IGenericRepository<Address>
    {
        Task<IEnumerable<Address>> GetAddressByContactName(string contactName);
        Task<IEnumerable<Address>> GetAddressByType(AddressType addressType);
    }
}
