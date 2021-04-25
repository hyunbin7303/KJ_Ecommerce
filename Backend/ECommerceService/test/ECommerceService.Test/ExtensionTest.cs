using ECommerce.Core.Models.OrderAggregate;
using ECommerce.Infrastructure.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceService.Test
{
    // source from https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types
    public class OrderStatusType
    : Enumeration
    {
        public static OrderStatusType None = new OrderStatusType(1, nameof(None));
        public static OrderStatusType Ready = new OrderStatusType(2, nameof(Ready));
        public static OrderStatusType Submitted = new OrderStatusType(3, nameof(Submitted));
        public static OrderStatusType Pending = new OrderStatusType(4, nameof(Pending));
        public static OrderStatusType PendingSubmitted = new OrderStatusType(5, nameof(PendingSubmitted));
        public static OrderStatusType Filled = new OrderStatusType(6, nameof(Filled));
        public static OrderStatusType Cancelled = new OrderStatusType(7, nameof(Cancelled));
        public OrderStatusType(int id, string name)
            : base(id, name)
        {
        }
    }
    class ExtensionTest
    {
        // Test failed.
        [Test]
        public void EnumExtensions_ReturnStringAsCancelled()
        {
            var check = EnumExtensions.ToDescriptionString(OrderStatus.Cancelled);
            Assert.AreEqual("Cancelled", check);
        }
        [Test]
        public void Enumeration_OrderStatusType_Return()
        {
            var check = OrderStatusType.None;
            var str = check.ToString();
            Assert.AreEqual("None", str);

            var check2 = OrderStatusType.Pending;
            var Pending = check2.ToString();
            Assert.AreEqual("Pending", Pending);
        }

    }
}
