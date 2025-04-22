using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IServiceManager _manager;

        public DestinationController(IServiceManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Index()
        {
            var destinations = await _manager.DestinationService.GetAllDestionsAsyn(false);
            return View(destinations);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
