using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.BusinessServices
{
    public interface IOrderService
    {
        Task CreateOrder(string cartId);
        Task CancelOrder(string orderId);
        Task CheckoutOrder(string orderId);
        Task AddOrderItem(string orderId, List<string> orderItemId);
        Task RemoveOrderItem(string orderId, List<string> orderItemId);


    }
}
