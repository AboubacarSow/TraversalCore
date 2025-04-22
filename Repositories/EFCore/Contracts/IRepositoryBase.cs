using System.Linq.Expressions;

namespace Repositories.EFCore.Contracts
{
    public interface IRepositoryBase<T> where T :class
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition, bool trackChanges);
        void Insert(T entity);
        void Edit(T entity);
        void Remove(T entity);
    }
}
