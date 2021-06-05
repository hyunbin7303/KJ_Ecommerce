using ECommerce.Core.Models.CartAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Interfaces
{
    public interface ICartItemRepository : IGenericRepository<CartItem>
    {
    }
}
