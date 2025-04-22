using Entities.Models;

namespace Repositories.EFCore.Contracts
{
    public interface ISocialMediaRepository
    {
        Task<IEnumerable<SocialMedia>> GetAllSocialMedias(bool trackChanges);
        Task<SocialMedia> GetById(int id, bool trackChanges);
        void Create(SocialMedia model);
        void Update(SocialMedia model);
        void Delete(SocialMedia model);
    }
   

}
