using DTOs.DestinationDtos;
using DTOs.FeatureDtos;

namespace Services.Contracts
{
    public interface IFeatureService
    {
        Task<List<FeatureDto>> GetAllFeaturesAsyn(bool trackChanges);
        Task<FeatureDto> GetOneFeatureById(int id, bool trackChanges);
    }
}
