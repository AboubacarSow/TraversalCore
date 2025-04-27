using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;

namespace Repositories.EFCore.Models
{
    public class ReservationRepository : RepositoryBase<Reservation>, IReservationRepository
    {
        public ReservationRepository(RepositoryContext context) : base(context)
        {
        }

        public void Create(Reservation model) => Insert(model);
        public void Delete(Reservation model) => Remove(model);
        public async Task<IEnumerable<Reservation>> GetAllReservations(bool trackChanges) =>
                    await FindAll(trackChanges).ToListAsync();
        public async Task<Reservation> GetById(int id, bool trackChanges) =>
            await FindByCondition(r => r.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public  IQueryable<Reservation> GetByUserId(int id, bool trackChanges)
        {
           return FindByCondition(r => r.UserId.Equals(id), trackChanges);
        }

        public void Update(Reservation model) => Edit(model);
       
    }
}
