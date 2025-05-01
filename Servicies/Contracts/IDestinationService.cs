using DTOs.DestinationDtos;

namespace Services.Contracts
{
    public interface IDestinationService
    {
         Task<List<DestinationDto>> GetAllDestinationsAsyn(bool trackChanges);
        Task<DestinationDto> GetOneDestinationById(int id, bool trackChanges);
        Task CreateAsync(CreateDestinationDto destinationDto);
        Task UpdateAsync(UpdateDestinationDto destinatioDto);
        Task<UpdateDestinationDto> GetOneDestinationForUpdate(int id,bool trackChanges);
        Task DeleteAsync(int id,bool trackChanges);

    }
}
