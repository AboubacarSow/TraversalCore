using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;

namespace Repositories.EFCore.Models
{
    public class NewsLetterRepository : RepositoryBase<NewsLetter>, INewsLetterRepository
    {
        public NewsLetterRepository(RepositoryContext context) : base(context)
        {
        }

        public void Create(NewsLetter model) => Insert(model);
        public void Delete(NewsLetter model) => Remove(model);
        public async Task<IEnumerable<NewsLetter>> GetAllNewsLetters(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<NewsLetter> GetById(int id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges).FirstOrDefaultAsync();

        public void Update(NewsLetter model) => Edit(model);
        
    }
}
