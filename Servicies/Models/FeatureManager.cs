using AutoMapper;
using Azure.Core;
using DTOs.FeatureDtos;
using Repositories.EFCore.Contracts;
using Services.Contracts;

namespace Services.Models
{
    public class FeatureManager : IFeatureService
    {
        private readonly IRepositoryManager? _manager;
        private readonly IMapper _mapper;

        public FeatureManager(IRepositoryManager? manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }


        public async Task<List<FeatureDto>> GetAllFeaturesAsyn(bool trackChanges)
        {
            var features = await _manager.Feature.GetAllFeatures(trackChanges);
            return _mapper.Map<List<FeatureDto>>(features);
        }

        public async Task<FeatureDto> GetOneFeatureById(int id, bool trackChanges)
        {
            var feature = await _manager.Feature.GetById(id, trackChanges);
            return _mapper.Map<FeatureDto>(feature);
        }
    }
}
