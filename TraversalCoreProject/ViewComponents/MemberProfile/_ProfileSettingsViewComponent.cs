using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberProfile
{
    public class _ProfileSettingsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
