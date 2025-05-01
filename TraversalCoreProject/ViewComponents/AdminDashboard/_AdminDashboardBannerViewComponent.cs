using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
    public class _AdminDashboardBannerViewComponent :ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
