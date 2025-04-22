using AutoMapper;
using DTOs.FeatureDtos;
using Entities.Models;

namespace TraversalCoreProject.Utilities.AutoMapper
{
    public class FeatureMapper :Profile
    {
        public FeatureMapper()
        {
            CreateMap<Feature, FeatureDto>();
        }
    }
}
