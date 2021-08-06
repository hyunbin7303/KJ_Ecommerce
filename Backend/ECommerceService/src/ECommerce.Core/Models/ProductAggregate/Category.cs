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
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ParentId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
