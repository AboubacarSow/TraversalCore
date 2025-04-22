using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
