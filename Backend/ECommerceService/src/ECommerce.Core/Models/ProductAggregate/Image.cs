using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models.ProductAggregate
{
    public class Image : Entity<int>
    {
        public string ImageTitle { get; set; }
        public string ImageUrl { get; set; }
    }
}
