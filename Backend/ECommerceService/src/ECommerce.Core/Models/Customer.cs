using ECommerce.Core.Interfaces;
namespace ECommerce.Core.Models
{
    public class Customer : Entity<string>
    {
        public string UserId { get; set; }
        public int AddressId { get; set; }
        public int VendorId { get; set;  }
        public string UserName { get; set; }
        public string CustomerName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
