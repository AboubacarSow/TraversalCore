using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area(areaName:"Member")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
           var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Name = String.Concat(user.FirstName, " ", user.LastName);
            ViewBag.Image = user.Image;
            return View();
        }
    }
}
