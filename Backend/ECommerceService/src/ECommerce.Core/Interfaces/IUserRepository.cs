using ECommerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> CreateUser(User user);
        Task<User> GetActiveUser();
    }
}
