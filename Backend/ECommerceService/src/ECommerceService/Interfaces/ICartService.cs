﻿using ECommerce.Core.Models.CartAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ECommerce.Interfaces
{
    public interface ICartService
    {
        Cart newShoppingCart(string userId, int vendorId);
        Task TransferBasket(string cartId, string userId);
        Task<IList<CartItem>> GetCartItemsByCartId(string cartId);
        Task<IList<Cart>> GetActiveCarts(string customerId);
        Task<Cart> GetActiveCartCurrent(string customerId);
        Task AddItemToCart(string cartId, int productId, int quantity = 1);
        Task SetQuantities(string cartId, Dictionary<string, int> quantities); // https://github.com/dotnet-architecture/eShopOnWeb/blob/master/src/ApplicationCore/Interfaces/IBasketService.cs
        Task RemoveItemFromCart(string cartId, string itemId);
        Task ActivateCart(string cartId);
    }
}
