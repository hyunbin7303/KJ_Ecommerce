using ECommerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        public Customer FindByUserName(string UserName);

    }
}
