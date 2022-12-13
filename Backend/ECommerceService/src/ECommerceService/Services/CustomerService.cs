using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Interfaces;
using ECommerce.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public Task CreateNewCustomer(CreateCustomerDTO newCustomerDTO)
        {
            // Need to check if customer Exists in the system... but how? by customer Id ? 
            //  _customerRepository.InsertAsync()
            throw new NotImplementedException();
        }
        public Task<Address> GetAddressByCustomerId(string customerId)
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
