using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public string ImageTitle { get; set; }
        public string ImageUrl { get; set; }
    }
}
