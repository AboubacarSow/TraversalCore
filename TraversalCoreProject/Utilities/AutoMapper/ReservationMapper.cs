using AutoMapper;
using DTOs.ReservationDtos;
using Entities.Models;

namespace TraversalCoreProject.Utilities.AutoMapper
{
    public class ReservationMapper : Profile
    {
        public ReservationMapper()
        {
            CreateMap<Reservation, ReservationDto>();
            CreateMap<ReservationForInsertionDto, Reservation>();
            CreateMap<ReservationForUpdateDto, Reservation>().ReverseMap();
        }
    }
}
