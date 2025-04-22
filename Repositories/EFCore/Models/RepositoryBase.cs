using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repositories.EFCore.Models
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T: class
    {
        protected RepositoryContext _context;

        public RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }
        public void Remove(T entity) => _context.Set<T>().Remove(entity);
        public IQueryable<T> FindAll(bool trackChanges)
        {
            return !trackChanges
                ? _context.Set<T>().AsNoTracking()
                : _context.Set<T>();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition, bool trackChanges)
        {
            return !trackChanges
                ? _context.Set<T>().Where(condition).AsTracking()
                : _context.Set<T>().Where(condition);
        }
        public void Insert(T entity)=> _context.Set<T>().Add(entity);
        public void Edit(T entity)=> _context.Set<T>().Update(entity);

    }
}
