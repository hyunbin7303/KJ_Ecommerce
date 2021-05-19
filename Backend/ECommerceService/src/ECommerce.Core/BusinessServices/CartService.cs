using Ardalis.GuardClauses;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.CartAggregate;
using ECommerce.Core.Models.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Core.BusinessServices
{
    public class CartService : ICartRepository
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }      

        public async Task<Cart> NewShoppingCart(int vendorId)
        {
            var cart = new Cart()
            {
                Id = Guid.NewGuid().ToString(),
                VendorId = vendorId,
            };
            _cartRepository.InsertAsync(cart);
            return cart;
        }
        public async Task AddItemToCart(string cartId, int productId, decimal quantity)
        {
            var cart = await _cartRepository.GetByIdAsync(cartId);
            // check 

            cart.AddCartItem(productId, quantity);
            _cartRepository.UpdateAsync(cart);
        }

        public async Task RemoveItemFromCart(string cartId, string itemId)
        {
            var cart = await _cartRepository.GetByIdAsync(cartId);
            cart.RemoveCartItem(itemId);
            _cartRepository.UpdateAsync(cart);
        }

        public Task<IEnumerable<CartItem>> GetllCartItemsByCartId(string cartId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveCartitems(string cartitemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> GetAll()
        {
            var carts = _cartRepository.GetAll();
            return carts;
        }

        public Task<Cart> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public bool TryGetObject(object id, out object obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> Get(Expression<Func<Cart, bool>> filter = null, Func<IQueryable<Cart>, IOrderedQueryable<Cart>> orderBy = null, string includeProperties = "", CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> GetWithSql(string query, params object[] paras)
        {
            throw new NotImplementedException();
        }

        public void InsertAsync(Cart obj, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(Cart obj, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        public void Delete(Cart entity)
        {
            throw new NotImplementedException();
        }
    }
}
