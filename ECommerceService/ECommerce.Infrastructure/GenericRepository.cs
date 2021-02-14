using ECommerce.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace ECommerce.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private MainEcommerceDBContext context;
        internal DbSet<T> dbSet = null;
        public GenericRepository(MainEcommerceDBContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
        public void Delete(object id)
        {
            T existing = dbSet.Find(id);
            dbSet.Remove(existing);
        }
        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }
        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }
        public virtual T GetById(object id)
        {
            return dbSet.Find(id);
        }
        public virtual IEnumerable<T> GetWithSql(string query, params object[] paras)
        {
            return dbSet.FromSqlRaw<T>(query, paras);
        }
        public virtual void Insert(T obj)
        {
            dbSet.Add(obj);
        }
        public virtual void Save()
        {
            context.SaveChanges();
        }
        public virtual void Update(T obj)
        {
            dbSet.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
        }
    }
}
