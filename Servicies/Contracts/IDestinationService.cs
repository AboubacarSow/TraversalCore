using DTOs.DestinationDtos;

namespace Services.Contracts
{
    public interface IDestinationService
    {
         Task<List<DestinationDto>> GetAllDestionsAsyn(bool trackChanges);
        Task<DestinationDto> GetOneDestinationById(int id, bool trackChanges);

    }
}
