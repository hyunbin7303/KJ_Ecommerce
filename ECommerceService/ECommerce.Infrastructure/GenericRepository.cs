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
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.dbSet = context.Set<T>();
        }
        public void Delete(object id)
        {
            T existing = dbSet.Find(id);
            if (existing == null)
            {
                throw new ArgumentException(" object doesn't exist.");
            }
            else
            {
                dbSet.Remove(existing);
            }
        }
        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = dbSet;
            if(filter != null)
            {
                query = query.Where(filter);
            }

            foreach(var includeProperty in includeProperties.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if(orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return orderBy(query).ToList();
            }
        }
        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }
        public virtual T GetByIdAsync(object id)
        {
            return dbSet.Find(id);
        }
        public virtual IEnumerable<T> GetWithSql(string query, params object[] paras)
        {
            return dbSet.FromSqlRaw<T>(query, paras);
        }
        public virtual void Insert(T obj)
        {
            if(obj == null)
            {
                throw new ArgumentException("entity");
            }
            dbSet.Add(obj);
            Save();
        }
        public virtual void Save()
        {
            context.SaveChanges();
        }
        public virtual void Update(T obj)
        {
            if(obj == null)
            {
                throw new ArgumentException("entity");
            }
            dbSet.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
        }
        public bool TryGetObject(object id, out object obj)
        {
            throw new NotImplementedException();
        }
    }
}
