using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ECommerce.Query
{
    public class ProductDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public double? UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        //Got source from here: https://mentormate.com/blog/service-and-repository-layer-interaction-in-c/
        //public static Expression<Func<Product, ProductDetailsDTO>> ProductSelector
        //{
        //    get
        //    {
        //        return p => new ProductDetailsDTO()
        //        {
        //            Name = p.Name,
        //            Description = p.Description,
        //            UnitPrice = p.UnitPrice,
        //            UnitsInStock = p.UnitsInStock,
        //        };
        //    }
        //}


    }
}
