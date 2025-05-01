using AutoMapper;
using DTOs.DestinationDtos;
using Entities.Models;
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
        public async Task CreateAsync(CreateDestinationDto destinationDto)
        {
            var destination = _mapper.Map<Destination>(destinationDto);
            _manager.Destination.Create(destination);
            await _manager.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id, bool trackChanges)
        {
            var destination = await _manager.Destination.GetById(id, trackChanges);
            _manager.Destination.Delete(destination);
            await _manager.SaveChangesAsync();
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

        public async Task<UpdateDestinationDto> GetOneDestinationForUpdate(int id,bool trackChanges)
        {
            var destination = await _manager.Destination.GetById(id, trackChanges);
            return _mapper.Map<UpdateDestinationDto>(destination);
        }

        public async Task UpdateAsync(UpdateDestinationDto destinationDto)
        {
            var destination = _mapper.Map<Destination>(destinationDto);
             _manager.Destination.Update(destination);
            await _manager.SaveChangesAsync();
        }
    }
}
