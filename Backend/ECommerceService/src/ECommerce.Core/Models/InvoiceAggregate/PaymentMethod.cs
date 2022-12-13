using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models
{
    public class PaymentMethod : Entity<int>
    {
        public PaymentMethod()
        {
        }

        public string Description { get; set; }
        public string TrnCode { get; set; }
        public string MethodCode { get; set; }

    }
}
