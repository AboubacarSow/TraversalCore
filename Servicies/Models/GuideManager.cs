using AutoMapper;
using DTOs.GuideDtos;
using Repositories.EFCore.Contracts;
using Services.Contracts;

namespace Services.Models
{
    public class GuideManager : IGuideService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public GuideManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<List<GuideDto>> GetAllGuidesAsyn(bool trackChanges)
        {
            var guides = await _manager.Guide.GetAllGuides(trackChanges);
            return _mapper.Map<List<GuideDto>>(guides);
        }

        public async Task<GuideDto> GetOneGuideById(int id, bool trackChanges)
        {
            var guide = await _manager.Guide.GetById(id, trackChanges);
            return _mapper.Map<GuideDto>(guide);
        }
    }
}
