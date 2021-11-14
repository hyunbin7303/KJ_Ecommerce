using ECommerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> CreateUserAsync(User user);
        Task<User> GetUserByAccountAndVendorId(string account, int vendorId);
        Task<User> GetActiveUser();
    }
}
