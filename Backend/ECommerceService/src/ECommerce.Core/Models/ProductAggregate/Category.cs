using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models.ProductAggregate
{
    public class Category : Entity<int>
    {
        public Category()
        {
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        //TODO Needs to update Category class (Check the table please). 
    }
}
