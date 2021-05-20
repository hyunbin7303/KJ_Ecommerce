using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(MainEcommerceDBContext context) : base(context)
        {
        }
    }
}
