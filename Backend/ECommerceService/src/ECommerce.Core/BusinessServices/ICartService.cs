using ECommerce.Core.Models.CartAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ECommerce.Core.BusinessServices
{
    public interface ICartService
    {
        Task TransferBasket(string cartId, string userId);
        Task AddItemToCart(string cartId, int productId, int quantity = 1);
        Task SetQuantities(string cartId, Dictionary<string, int> quantities); // https://github.com/dotnet-architecture/eShopOnWeb/blob/master/src/ApplicationCore/Interfaces/IBasketService.cs
        Task DeleteCart(string cartId);
    }
}
