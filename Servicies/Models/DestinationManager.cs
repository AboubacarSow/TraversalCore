using AutoMapper;
using DTOs.DestinationDtos;
using Repositories.EFCore.Contracts;
using Services.Contracts;

namespace Services.Models
{
    public class DestinationManager : IDestinationService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public DestinationManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<List<DestinationDto>> GetAllDestinationsAsyn(bool trackChanges)
        {
            var destinations = await _manager.Destination.GetAllDestinations(trackChanges);
            return _mapper.Map<List<DestinationDto>>(destinations);
        }

        public async Task<DestinationDto> GetOneDestinationById(int id, bool trackChanges)
        {
            var destination = await _manager.Destination.GetById(id, trackChanges);
            return _mapper.Map<DestinationDto>(destination);
        }
    }
}
