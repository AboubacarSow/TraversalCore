using DTOs.GuideDtos;
namespace Services.Contracts
{
    public interface IGuideService
    {
        Task<List<GuideDto>> GetAllGuidesAsyn(bool trackChanges);
        Task<GuideDto> GetOneGuideById(int id, bool trackChanges);
    }
}
