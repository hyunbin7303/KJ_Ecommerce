using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Domain.Models
{
    public partial class ProductReview
    {
        public string Id { get; set; }
        public int CustomerId { get; set; }
        public int Rating { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
    }
}
