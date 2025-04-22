using Entities.Models;

namespace Repositories.EFCore.Contracts
{
    public interface IGuideRepository
    {
        Task<IEnumerable<Guide>> GetAllGuides(bool trackChanges);
        Task<Guide> GetById(int id, bool trackChanges);
        void Create(Guide model);
        void Update(Guide model);
        void Delete(Guide model);
    }
}
