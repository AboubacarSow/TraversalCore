using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;

namespace Repositories.EFCore.Models
{
    public class TestimonialRepository : RepositoryBase<Testimonial>, ITestimonialRepository
    {
        public TestimonialRepository(RepositoryContext context) : base(context)
        {
        }

        public void Create(Testimonial model) => Insert(model);
        public void Delete(Testimonial model) => Remove(model);
        public async Task<IEnumerable<Testimonial>> GetAllTestimonials(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<Testimonial> GetById(int id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges).FirstOrDefaultAsync();

        public void Update(Testimonial model) => Edit(model);
        
    }
}
