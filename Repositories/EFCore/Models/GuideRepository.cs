using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;

namespace Repositories.EFCore.Models
{
    public class GuideRepository : RepositoryBase<Guide>, IGuideRepository
    {
        public GuideRepository(RepositoryContext context) : base(context)
        {
        }

        public void Create(Guide model) => Insert(model);
        public void Delete(Guide model) => Remove(model);
        public async Task<IEnumerable<Guide>> GetAllGuides(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<Guide> GetById(int id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges).FirstOrDefaultAsync();

        public void Update(Guide model) => Edit(model);
        
    }
}
