using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Domain.Models
{
    public class Attribute
    {
        public Attribute()
        {
            ProductAttributes = new List<ProductAttribute>();
        }

        public int Id { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
    }
}
