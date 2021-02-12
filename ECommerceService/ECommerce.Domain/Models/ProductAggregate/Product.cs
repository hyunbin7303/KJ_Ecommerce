
namespace ECommerce.Domain.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityPerUnit { get; set; }
        public float UnitPrice { get; set; }
        public bool UnitsInStock { get; set; }
    //    public EUnitOfMeasurement UnitOfMeasurement { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
