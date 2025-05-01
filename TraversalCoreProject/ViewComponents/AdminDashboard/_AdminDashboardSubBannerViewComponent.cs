using Microsoft.AspNetCore.Mvc;
using Repositories.EFCore.ContextFactory;
using Services.Contracts;

namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
    public class _AdminDashboardSubBannerViewComponent : ViewComponent 
    {
        private readonly IServiceManager _serviceManager;
        private readonly RepositoryContext _context;

        public _AdminDashboardSubBannerViewComponent(IServiceManager serviceManager, RepositoryContext context)
        {
            _serviceManager = serviceManager;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.CountOfDestinations =( await _serviceManager.DestinationService.GetAllDestinationsAsyn(false)).Count;
            ViewBag.CountOfUsers = _context.Users.Count();
            
            return View();
        }
    }

}
