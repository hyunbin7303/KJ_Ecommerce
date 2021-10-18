using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Infrastructure.Repository.Base;


namespace ECommerce.Infrastructure.Repository
{
    public class UserVendorRepository : GenericRepository<UserVendor>, IUserVendorRepository
    {
        public UserVendorRepository(MainEcommerceDBContext context) : base(context)
        {
        }
    }
}
