using System;

namespace ECommerce.Domain.Models
{
    public class Supplier : Entity
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public DateTimeOffset? LatestupdatedTime { get; set; }
    }
}
