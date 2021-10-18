
namespace ECommerce.Query
{
    public class ProductCreateDTO
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public int VendorId { get; private set; }
        public int? CategoryId { get; private set; }
        public double? UnitPrice { get; set; }
        public string Note { get; set; }
    }
}
