using Entities.Models;

namespace Repositories.EFCore.Contracts
{
    public interface IDestinationRepository
    {
        Task<IEnumerable<Destination>> GetAllDestinations(bool trackChanges);
        Task<Destination> GetById(int id, bool trackChanges);
        void Create(Destination model);
        void Update(Destination model);
        void Delete(Destination model);
    }
}
