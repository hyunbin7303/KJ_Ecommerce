using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ECommerce.Domain.Models
{
    public class Invoice : Entity
    {
        public Invoice()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
        }
        public DateTime Date { get; set; }
        public string CustomerId { get; set; }
        public string SupplierId { get; set; }
        public decimal Total { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
    
        public decimal InvoiceTotal
        {
            get { return this.InvoiceItems.Select(p => p.Amount).Sum(); }
        }
    
    }
}
