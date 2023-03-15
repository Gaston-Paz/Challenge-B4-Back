using System.Linq.Expressions;

namespace Backend.Data.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {

        T Create(T entity);
        T Update(T entity);
        T? GetOne(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Search(Expression<Func<T, bool>>? where = null);

    }
}

