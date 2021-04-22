using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Domain.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string TrnCode { get; set; }
        public string MethodCode { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
