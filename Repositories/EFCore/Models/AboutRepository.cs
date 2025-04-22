using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;

namespace Repositories.EFCore.Models
{
    public class AboutRepository :RepositoryBase<About>, IAboutRepository
    {
        public AboutRepository(RepositoryContext context) : base(context)
        {
        }
        public void Create(About model) => Insert(model);
        public void Delete(About model) => Remove(model);
        public async Task<IEnumerable<About>> GetAllAbouts(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();
        public async Task<About> GetById(int id, bool trackChanges) =>
            await FindByCondition(a => a.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
        public void  Update(About model) => Edit(model);
        
    }
}
