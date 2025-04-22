using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;

namespace Repositories.EFCore.Models
{
    public class FeatureRepository : RepositoryBase<Feature>, IFeatureRepository
    {
        public FeatureRepository(RepositoryContext context) : base(context)
        {
        }

        public void Create(Feature model) => Insert(model);
        public void Delete(Feature model) => Remove(model);
        public async Task<IEnumerable<Feature>> GetAllFeatures(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<Feature> GetById(int id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges).FirstOrDefaultAsync();

        public void Update(Feature model) => Edit(model);
        
    }
}
