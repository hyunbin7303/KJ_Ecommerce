using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Models
{
    public class Payment : Entity
    {
        public string InvoiceId { get; set; }
        public int PaymentMethodId { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Status { get; set; }
        public string TransactionType { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
