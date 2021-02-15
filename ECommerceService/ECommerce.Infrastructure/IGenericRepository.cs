using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ECommerce.Infrastructure
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByIdAsync(object id);
        bool TryGetObject(object id, out object obj);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        IEnumerable<T> GetWithSql(string query, params object[] paras);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Delete(T entity);
        void Save();
    }
}
