
namespace ECommerce.Query
{
    public class ProductUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public int VendorId { get; private set; }
        public int? CategoryId { get; private set; }
        public string ProductFormat { get; set; }
        public int? QuantityPerUnit { get; set; }
        public double? UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public double? Discount { get; set; }
        public bool OrderAvailable { get; set; }
        public bool ProductAvailable { get; set; }
        public bool DiscountAvailable { get; set; }
        public int? ImageId { get; set; }
        public string Note { get; set; }
    }
}
