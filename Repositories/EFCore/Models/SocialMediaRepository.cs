using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;

namespace Repositories.EFCore.Models
{
    public class SocialMediaRepository : RepositoryBase<SocialMedia>, ISocialMediaRepository
    {
        public SocialMediaRepository(RepositoryContext context) : base(context)
        {
        }

        public void Create(SocialMedia model) => Insert(model);
        public void Delete(SocialMedia model) => Remove(model);
        public async Task<IEnumerable<SocialMedia>> GetAllSocialMedias(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<SocialMedia> GetById(int id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges).FirstOrDefaultAsync();

        public void Update(SocialMedia model) => Edit(model);
        
    }
}
