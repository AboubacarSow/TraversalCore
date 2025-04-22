using Entities.Models;

namespace Repositories.EFCore.Contracts
{
    public interface IFeatureRepository
    {
        Task<IEnumerable<Feature>> GetAllFeatures(bool trackChanges);
        Task<Feature> GetById(int id, bool trackChanges);
        void Create(Feature model);
        void Update(Feature model);
        void Delete(Feature model);
    }
}
