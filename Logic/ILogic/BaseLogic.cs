using System.Linq.Expressions;

namespace Backend.Logic.ILogic
{
    public interface IBaseLogic<T, T2>
        where T : class
        where T2 : class
    {
        T2 Create(T2 entity);
        T2 Update(T2 entity);
        T2 GetOne(int id);
        List<T2> GetAll();
        List<T2> Search(Expression<Func<T, bool>>? where = null);
    }
}
