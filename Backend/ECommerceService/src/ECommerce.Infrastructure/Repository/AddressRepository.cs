using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(MainEcommerceDBContext context) : base(context)
        {
        }
        public Task<IEnumerable<Address>> GetAddressByContactName(string contactName)
        {
            Expression<Func<Address, bool>> exprAddress = x => x.ContactName == contactName;
            var addrs = Get(exprAddress);
            return Task.FromResult(addrs);
        }
        public Task<IEnumerable<Address>> GetAddressByType(AddressType addressType)
        {
            string addrTypeStr = Enum.GetName(typeof(AddressType), addressType);
            Expression<Func<Address, bool>> exprAddress = x => x.AddressType == addrTypeStr;
            var addrs = Get(exprAddress);
            return Task.FromResult(addrs);
        }
    }
}
