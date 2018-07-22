using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Unity.Attributes;

namespace DataAccessPoliza.Repository
{
    public class GenericRepository<T> :  IGenericRepository<T> where T : class
    {
        internal GestionPolizaEntities _context;


        public GenericRepository()
        {
            _context = new GestionPolizaEntities();

        }

        public GestionPolizaEntities _Context { get { return this._context; }}
        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            return query;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    
    }
}
