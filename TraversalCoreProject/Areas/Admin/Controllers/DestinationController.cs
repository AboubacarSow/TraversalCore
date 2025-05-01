using AutoMapper;
using DTOs.DestinationDtos;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area(areaName:"Admin")]
    public class DestinationController : Controller
    {
        private readonly IServiceManager _serviceManager;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public DestinationController(IServiceManager serviceManager, IMapper mapper, IFileService fileService)
        {
            _serviceManager = serviceManager;
            _mapper = mapper;
            _fileService = fileService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var destinations = await _serviceManager.DestinationService.GetAllDestinationsAsyn(false);
            var destinationDtos = _mapper.Map<List<DestinationDto>>(destinations);
            return View(destinationDtos);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateDestinationDto destinationDto)
        {
            if (!ModelState.IsValid)
                return View(destinationDto);
            if (destinationDto.ImageUrl == null)
            {
                ModelState.AddModelError("","Lütfen resim yükleyin");
                return View(destinationDto);
            }
            destinationDto.Image = await _fileService.SaveImageAsync(destinationDto.ImageUrl);           
            await _serviceManager.DestinationService.CreateAsync(destinationDto);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var destination = await _serviceManager
                .DestinationService
                .GetOneDestinationForUpdate(id,false);
            return View(destination);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateDestinationDto destinationDto)
        {
            if (!ModelState.IsValid)
                return View(destinationDto);
            if (destinationDto.ImageUrl != null)
            {
                destinationDto.Image = await _fileService.SaveImageAsync(destinationDto.ImageUrl);
            }
            await _serviceManager.DestinationService.UpdateAsync(destinationDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            await _serviceManager.DestinationService.DeleteAsync(id,false);
            return RedirectToAction(nameof(Index));
        }
    }
}
