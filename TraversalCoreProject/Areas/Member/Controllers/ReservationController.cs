using DTOs.ReservationDtos;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Contracts;
using System.Linq;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area(areaName: "Member")]
    public class ReservationController : Controller
    {
        private readonly IServiceManager _serviceManager;
        private readonly UserManager<AppUser> _userManager;
        public ReservationController(IServiceManager serviceManager, UserManager<AppUser> userManager)
        {
            _serviceManager = serviceManager;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await GetDestinationAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ReservationForInsertionDto reservationDto)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            reservationDto.UserId = user?.Id;
            reservationDto.Status = "Onay Bekliyor";
            await _serviceManager.ReservationService.CreateAsync(reservationDto);
            return RedirectToAction(nameof(ActiveReservations));
        }
        private async Task GetDestinationAsync()
        {
            ViewBag.Destinations = (from d in await _serviceManager.DestinationService.GetAllDestinationsAsyn(false)
                                    select new SelectListItem
                                    {
                                        Text = d.City,
                                        Value = d.Id.ToString()
                                    }).ToList();
        }
        public IActionResult ActiveReservations()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> PendingReservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var reservations = await _serviceManager
                .ReservationService
                .GetByUserIdAndStatus(user.Id, "Onay Bekliyor", false);
            return View(reservations);
        }
        public IActionResult PastReservations()
        {
            return View();
        }
    }
}
