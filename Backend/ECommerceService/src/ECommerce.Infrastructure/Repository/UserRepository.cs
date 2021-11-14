using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(MainEcommerceDBContext context) : base(context)
        {
        }

        public Task<User> CreateUserAsync(User user)
        {
            var newUser = InsertAsync(user);
            return newUser;
        }

        public Task<User> GetActiveUser()
        { 
            //GetByIdAsync()
            throw new NotImplementedException();
        }
        private IOrderedQueryable<User> OrderingMethod(IQueryable<User> query)
        {
            return query.OrderBy(u => u.FirstName);
        }
        public Task<User> GetUserByAccountAndVendorId(string account, int vendorId)
        {
            Expression<Func<User, bool>> exprUser = x => (x.Account == account) && (x.VendorId == vendorId);
            var user = Get(exprUser, OrderingMethod).FirstOrDefault();
            return Task.FromResult(user);
        }
    }
}
