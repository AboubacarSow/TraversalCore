using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _FeatureViewComponent :ViewComponent
    {
        private readonly IServiceManager _manager;

        public _FeatureViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var features = await _manager.FeatureService.GetAllFeaturesAsyn(false);
            return View(features);
        }
    }
}
