using AutoMapper;
using DTOs.DestinationDtos;
using Entities.Models;

namespace TraversalCoreProject.Utilities.AutoMapper
{
    public class DestinationMapper : Profile
    {
        public DestinationMapper()
        {
            CreateMap<Destination, DestinationDto>();
        }
    }
}
