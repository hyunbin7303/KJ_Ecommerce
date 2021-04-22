using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Domain.Models
{
    public partial class Payment
    {
        public string Id { get; set; }
        public string InvoiceId { get; set; }
        public int PaymentMethodId { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Status { get; set; }
        public string TransactionType { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
