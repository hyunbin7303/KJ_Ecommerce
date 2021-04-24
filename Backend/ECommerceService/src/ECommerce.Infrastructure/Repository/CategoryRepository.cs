using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MainEcommerceDBContext context) : base(context)
        {
        }
    }
}
