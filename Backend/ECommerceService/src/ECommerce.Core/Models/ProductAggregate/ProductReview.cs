using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models.ProductAggregate
{
    public class ProductReview : Entity<int>
    {
        public string CustomerId { get; set; }
        public int Rating { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
    }
}
