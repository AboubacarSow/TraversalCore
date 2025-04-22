using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;

namespace Repositories.EFCore.Models
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(RepositoryContext context) : base(context)
        {
        }
        public void Create(Contact model) => Insert(model);
        public void Delete(Contact model) => Remove(model);
        public async Task<IEnumerable<Contact>> GetAllContacts(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<Contact> GetById(int id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges).FirstOrDefaultAsync();

        public void Update(Contact model) => Edit(model);
        
    }
}
