using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.CartAggregate;
using ECommerce.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(MainEcommerceDBContext context) : base(context)
        {
        }
        public Task AddItemToCart(string cartId, int productId, decimal quantity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartItem>> GetAllCartItemsByCartId(string cartId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveCartitems(string cartitemId)
        {
            throw new NotImplementedException();
        }
    }
}
