using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace ECommerce.Core.Models
{
    public class Payment : Entity<string>
    {
        public string InvoiceId { get; set; }
        public int PaymentMethodId { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Status { get; set; }
        public string TransactionType { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
