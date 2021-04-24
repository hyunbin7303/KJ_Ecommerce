using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;

namespace ECommerce.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<T> GetByIdAsync(object id);
        bool TryGetObject(object id, out object obj);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        IEnumerable<T> GetWithSql(string query, params object[] paras);
        void Insert(T obj);
        void Update(T obj);
        Task DeleteAsync(object id);
        void Delete(T entity);
        void Save();
    }
}
