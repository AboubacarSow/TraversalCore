using Entities.Models;

namespace Repositories.EFCore.Contracts
{
    public interface ITestimonialRepository
    {
        Task<IEnumerable<Testimonial>> GetAllTestimonials(bool trackChanges);
        Task<Testimonial> GetById(int id, bool trackChanges);
        void Create(Testimonial model);
        void Update(Testimonial model);
        void Delete(Testimonial model);
    }
}
