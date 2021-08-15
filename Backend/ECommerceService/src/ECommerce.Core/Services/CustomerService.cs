using ECommerce.Core.Models;
using ECommerce.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Services
{
    public class CustomerService : ICustomerService
    {
        public Task CreateNewCustomer(CreateCustomerDTO newCustomerDTO)
        {
            throw new NotImplementedException();
        }
        public Task UpdateAddress(string customerId, string addressId, Address addr)
        {
            throw new NotImplementedException();
        }
        public Task UpdateCustomerInfo(UpdateCustomerDTO updateCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
