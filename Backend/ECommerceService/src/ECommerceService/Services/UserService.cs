using AutoMapper;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Interfaces;
using ECommerce.Query;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper,IUserRepository userRepository)
        {
            _mapper = mapper;   
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository)); 
        }

        public Task<User> CreateUserAsync(CreateUserDTO userCreateDTO)
        {
            User user = _mapper.Map<User>(userCreateDTO);
            var user1 = _userRepository.CreateUserAsync(user);
            return user1;
        }
        public Task<User> UserGetUserByAccountAndVendorId(string account, int vendorId)
        {
            return _userRepository.GetUserByAccountAndVendorId(account, vendorId);
        }

        public Task<User> GetCurrentUserAsync(ClaimsIdentity identity, CancellationToken cancellationToken = default)
        {

            var claimsIdentity = identity;
            var userId = claimsIdentity.FindFirst("UserName")?.Value;
            throw new NotImplementedException();
        }
    }
}
