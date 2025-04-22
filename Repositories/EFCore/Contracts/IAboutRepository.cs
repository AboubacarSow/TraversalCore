using Entities.Models;

namespace Repositories.EFCore.Contracts
{
    public interface IAboutRepository 
    {
         Task<IEnumerable<About>> GetAllAbouts(bool trackChanges);
         Task<About> GetById(int id, bool trackChanges);
        void Create(About model);
        void Update(About model);
        void Delete(About model);


    }
}
