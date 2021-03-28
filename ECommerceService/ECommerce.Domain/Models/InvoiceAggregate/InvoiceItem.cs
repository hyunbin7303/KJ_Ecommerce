using System.ComponentModel.DataAnnotations.Schema;
namespace ECommerce.Domain.Models
{
    public class InvoiceItem : Entity
    {
        public string InvoiceId { get; set; }
        public string Code { get; set; }
        public decimal Amount { get; set; }
        [ForeignKey("InvoiceId")]
        public virtual Invoice Invoice { get; set; }
    }
}
