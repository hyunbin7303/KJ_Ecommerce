using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Models.OrderAggregate
{
    public class OrderStatus
    {
        public static string Pending = "Pending";
        public static string Cancelled = "Cancelled";
        public static string Submitted = "Submitted";
        public static string PendingSubmitted = "PendingSubmitted";
        public static string Filled = "Filled";
        public static string None = "None";
        public static string Ready = "Ready";
    }
}
