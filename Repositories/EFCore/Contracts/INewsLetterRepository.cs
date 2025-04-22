using Entities.Models;

namespace Repositories.EFCore.Contracts
{
    public interface INewsLetterRepository
    {
        Task<IEnumerable<NewsLetter>> GetAllNewsLetters(bool trackChanges);
        Task<NewsLetter> GetById(int id, bool trackChanges);
        void Create(NewsLetter model);
        void Update(NewsLetter model);
        void Delete(NewsLetter model);
    }
}
