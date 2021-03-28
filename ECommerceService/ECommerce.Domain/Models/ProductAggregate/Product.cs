namespace ECommerce.Domain.Models
{
    public class Product : Entity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SupplierId { get; set; }
        public string CustomerId { get; set; }
        public string ProductFormat { get; set; }
        public int? QuantityPerUnit { get; set; }
        public double? UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public int? CategoryId { get; set; }
        public string ImageAddress { get; set; }
        public string Note { get; set; }
        //public virtual Category Category { get; set; }
    }
}
