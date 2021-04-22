using ECommerce.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Repository
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(MainEcommerceDBContext context) : base(context)
        {
        }
    }
}
