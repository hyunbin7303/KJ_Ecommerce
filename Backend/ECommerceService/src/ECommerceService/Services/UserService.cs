using AutoMapper;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Interfaces;
using ECommerce.Query;
using System;
using System.Collections.Generic;
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

        public Task<bool> CreateUserAsync(UserCreateDTO userCreateDTO)
        {
            User user = _mapper.Map<User>(userCreateDTO);
            _userRepository.CreateUser(user);
            return Task.FromResult(true);

        }



        public Task<User> GetCurrentUserAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
