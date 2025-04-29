using AutoMapper;
using DTOs.GuideDtos;
using Entities.Models;

namespace TraversalCoreProject.Utilities.AutoMapper
{
    public class GuideMapper : Profile
    {
        public GuideMapper()
        {
            CreateMap<Guide, GuideDto>();
        }
    }
}
