using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models.ProductAggregate
{
    public class Attribute : Entity<int>
    {
        public Attribute()
        {
        }

        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public string Description { get; set; }

    }
}
