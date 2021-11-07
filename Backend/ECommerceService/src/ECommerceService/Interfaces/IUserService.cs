using ECommerce.Core.Models;
using ECommerce.Query;
using System.Threading;
using System.Threading.Tasks;
namespace ECommerce.Interfaces
{
    public interface IUserService
    {
        Task<User> GetCurrentUserAsync(CancellationToken cancellationToken = default);
        Task<bool> CreateUserAsync(UserCreateDTO userCreateDTO);
        //Task UpdateUserAsync(UserUpdateDTO userUpdateDTO);
    }
}
