using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Infrastructure.Repository.Base;


namespace ECommerce.Infrastructure.Repository
{
    public class VendorProdcutRepository : GenericRepository<VendorProduct>, IVendorProductRepository
    {
        public VendorProdcutRepository(MainEcommerceDBContext context) : base(context)
        {
        }
    }
}
