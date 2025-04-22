using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _TestimonialViewComponent :ViewComponent
    {
        private readonly IServiceManager _manager;

        public _TestimonialViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var testimonialdtos = await _manager.TestimonialService.GetAllTestimonialsAsyn(false);
            return View(testimonialdtos);
        }
    }
}
