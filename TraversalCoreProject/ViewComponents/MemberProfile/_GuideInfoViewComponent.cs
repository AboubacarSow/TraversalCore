using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.MemberProfile
{
    public class _GuideInfoViewComponent : ViewComponent
    {
        private readonly IServiceManager _serviceManager;

        public _GuideInfoViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var guides = await _serviceManager.GuideService.GetAllGuidesAsyn(false);
            return View(guides);
        }
    }
}
