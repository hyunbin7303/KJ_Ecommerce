using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //private EmployeeDBContext _context = null;
        //private DbSet<T> table = null;
        //public GenericRepository()
        //{
        //    this._context = new EmployeeDBContext();
        //    table = _context.Set<T>();
        //}
        //public GenericRepository(EmployeeDBContext _context)
        //{
        //    this._context = _context;
        //    table = _context.Set<T>();
        //}
        //public IEnumerable<T> GetAll()
        //{
        //    return table.ToList();
        //}
        //public T GetById(object id)
        //{
        //    return table.Find(id);
        //}
        //public void Insert(T obj)
        //{
        //    table.Add(obj);
        //}
        //public void Update(T obj)
        //{
        //    table.Attach(obj);
        //    _context.Entry(obj).State = EntityState.Modified;
        //}
        //public void Delete(object id)
        //{
        //    T existing = table.Find(id);
        //    table.Remove(existing);
        //}
        //public void Save()
        //{
        //    _context.SaveChanges();
        //}
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
