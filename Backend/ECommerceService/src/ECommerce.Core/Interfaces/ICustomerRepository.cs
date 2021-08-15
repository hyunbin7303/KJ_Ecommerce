using ECommerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer FindByUserName(string UserName);
    }
}
