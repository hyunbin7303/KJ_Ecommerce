using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double? UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
    }
}
