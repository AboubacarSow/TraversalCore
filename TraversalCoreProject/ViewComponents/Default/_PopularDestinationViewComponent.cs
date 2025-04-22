using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinationViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;
        public _PopularDestinationViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var destinations = await _manager.DestinationService.GetAllDestionsAsyn(false);
            return View(destinations);
        }
    }
}
