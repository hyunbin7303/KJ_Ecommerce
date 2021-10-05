using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class VendorRepository : GenericRepository<Vendor>, IVendorRepository
    {
        public VendorRepository(MainEcommerceDBContext context) : base(context)
        {
        }
        //public Task<IEnumerable<Product>> GetProductsByNameAsync(string productName)
        //{
        //    Expression<Func<Product, bool>> expressionProduct = x => x.Name == productName;
        //    var products = Get(expressionProduct);
        //    return Task.FromResult(products);
        //}
        //public Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        //{
        //    Expression<Func<Product, bool>> expressionCategory = x => x.CategoryId == categoryId;
        //    var check = Get(expressionCategory);
        //    return Task.FromResult(check);
        //}


    }
}
