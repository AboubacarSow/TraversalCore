using Entities.Models;

namespace Repositories.EFCore.Contracts
{
    public interface IReservationRepository
    {
        Task<IEnumerable<Reservation>> GetAllReservations(bool trackChanges);
       IQueryable<Reservation> GetByUserId(int id, bool trackChanges);
        Task<Reservation> GetById(int id, bool trackChanges);
        void Create(Reservation model);
        void Update(Reservation model);
        void Delete(Reservation model);
    }
}
