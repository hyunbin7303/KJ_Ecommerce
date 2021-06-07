﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using ECommerce.Core.Interfaces;
namespace ECommerce.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IQueryable<T> Query();
        Task<T> GetByIdAsync(object id);
        bool TryGetObject(object id, out object obj);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", CancellationToken cancellationToken = default);
        IEnumerable<T> GetWithSql(string query, params object[] paras);
        void InsertAsync(T obj, CancellationToken cancellationToken = default);
        void UpdateAsync(T obj, CancellationToken cancellationToken = default);
        Task DeleteAsync(object id, CancellationToken cancellationToken = default);
        void Delete(T entity);
    }
}
