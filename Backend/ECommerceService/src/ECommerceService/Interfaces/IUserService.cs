using ECommerce.Core.Models;
using ECommerce.Query;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
namespace ECommerce.Interfaces
{
    public interface IUserService
    {
        Task<User> UserGetUserByAccountAndVendorId(string account, int vendorId);
        Task<User> GetCurrentUserAsync(ClaimsIdentity identity, CancellationToken cancellationToken = default);
        Task<User> CreateUserAsync(CreateUserDTO userCreateDTO);
        //Task UpdateUserAsync(UserUpdateDTO userUpdateDTO);
    }
}
