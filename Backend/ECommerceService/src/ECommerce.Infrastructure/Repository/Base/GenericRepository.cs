using ECommerce.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;


namespace ECommerce.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal DbSet<T> dbSet = null;
        private MainEcommerceDBContext context;

        public GenericRepository(MainEcommerceDBContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.dbSet = context.Set<T>();
        }
        public async Task DeleteAsync(object id)
        {
            try
            {
                T existing = dbSet.Find(id);
                if (existing == null)
                {
                    // not found
                }

                dbSet.Remove(existing);
                await context.SaveChangesAsync();
                // Okay 
            }
            catch
            {
                // exception
            }

        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
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

        public virtual IEnumerable<T> GetWithSql(string query, params object[] paras)
        {
            return dbSet.FromSqlRaw<T>(query, paras);
        }

        public virtual void Insert(T obj)
        {
            if (obj == null)
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
            if (obj == null)
            {
                throw new ArgumentException("entity");
            }
            dbSet.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public bool TryGetObject(object id, out object obj)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetByIdAsync(object id)
        {
            return await dbSet.FindAsync(id);
        }
    }
}