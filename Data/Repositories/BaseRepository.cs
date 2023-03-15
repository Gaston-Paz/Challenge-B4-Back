using Backend.Data.IRepositories;
using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Backend.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        internal BackendContext _context;
        internal DbSet<T> DbSet;
        public BaseRepository(BackendContext context) 
        {
            this._context = context;
            DbSet = _context.Set<T>();

        }
        public virtual T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }


        public virtual IQueryable<T> GetAll()
        {
            var query = _context.Set<T>().AsNoTracking();
            return query;
        }

        public virtual T? GetOne(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual IQueryable<T> Search(Expression<Func<T, bool>>? where = null)
        {
            IQueryable<T> rdo = null != where ? _context.Set<T>().AsNoTracking().Where(where) : _context.Set<T>().AsNoTracking();
            return rdo;
        }

        public T Update(T entity)
        {
            _context.ChangeTracker.Clear();
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }
    }
}
