using DTOs.ReservationDtos;

namespace Services.Contracts
{
    public interface IReservationService
    {
        Task<List<ReservationDto>> GetAllReservationsAsyn(bool trackChanges);
        Task<ReservationDto> GetOneReservationById(int id, bool trackChanges);
        Task<List<ReservationDto>> GetByUserIdAndStatus(int userId, string status, bool trackChanges);
        Task CreateAsync(ReservationForInsertionDto reservationDto);

        Task UpdateAsync(ReservationForUpdateDto reservationDto);
    }
}
