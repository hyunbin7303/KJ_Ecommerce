using System.Collections.Generic;
namespace ECommerce.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string ParentId { get; set; }
        //public IList<Product> Products { get; set; } = new List<Product>();
        public string Description { get; set; }
    }

}