using Entities.Models;

namespace Repositories.EFCore.Contracts
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetAllContacts(bool trackChanges);
        Task<Contact> GetById(int id, bool trackChanges);
        void Create(Contact model);
        void Update(Contact model);
        void Delete(Contact model);
    }
}
