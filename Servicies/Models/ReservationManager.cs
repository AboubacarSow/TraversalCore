using AutoMapper;
using DTOs.DestinationDtos;
using DTOs.ReservationDtos;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.Contracts;
using Services.Contracts;

namespace Services.Models
{
    public class ReservationManager : IReservationService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public ReservationManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task CreateAsync(ReservationForInsertionDto reservationDto)
        {
            var reservation = _mapper.Map<Reservation>(reservationDto);
            _manager.Reservation.Create(reservation);
            await _manager.SaveChangesAsync();
        }

        public async Task<List<ReservationDto>> GetAllReservationsAsyn(bool trackChanges)
        {
            var reservations = await _manager.Reservation.GetAllReservations(trackChanges);
              return  _mapper.Map<List<ReservationDto>>(reservations);
            
        }

        public async Task<List<ReservationDto>> GetByUserIdAndStatus(int userId, string status, bool trackChanges)
        {
            var reservations = await _manager.Reservation
                .GetByUserId(userId, trackChanges)
                .Where(r => r.Status == status)
                .ToListAsync();
            return _mapper.Map<List<ReservationDto>>(reservations);
        }

        public async Task<ReservationDto> GetOneReservationById(int id, bool trackChanges)
        {
            var reservation = await _manager.Reservation.GetById(id, trackChanges);
            return _mapper.Map<ReservationDto>(reservation);
        }

        public async Task UpdateAsync(ReservationForUpdateDto reservationDto)
        {
            var reservation = _mapper.Map<Reservation>(reservationDto);
            _manager.Reservation.Update(reservation);
            await _manager.SaveChangesAsync();
        }
    }
}
