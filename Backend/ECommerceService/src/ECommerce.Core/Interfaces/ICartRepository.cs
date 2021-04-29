using ECommerce.Core.Models.CartAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Interfaces
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
      
    }
}
