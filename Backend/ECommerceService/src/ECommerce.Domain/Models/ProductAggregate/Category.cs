using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Domain.Models
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
