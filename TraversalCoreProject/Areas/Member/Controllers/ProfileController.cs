using AutoMapper;
using DTOs.AccountDtos;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace TraversalCoreProject.Areas.Member.Controllers
{

    [Area(areaName: "Member")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService; 

        public ProfileController(UserManager<AppUser> userManager, IMapper mapper,
            IFileService fileService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _fileService = fileService;
        }
        [HttpGet]
        public async Task<IActionResult> Details()
        {
           var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var _userDto = _mapper.Map<UserDto>(user);
            return View(_userDto);
        }
        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userDto = _mapper.Map<UserForUpdateDto>(user);
            return View(userDto);
        }
        
        [HttpPost]
        public async Task<IActionResult> Update(UserForUpdateDto userDto)
        {
            if (!ModelState.IsValid) return View(userDto);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var checkPassword = await _userManager.CheckPasswordAsync(user, userDto.Password);
            if (!checkPassword)
            {
                ModelState.AddModelError("", "Girdiğiniz şifre Hatalıdır");
                return View(userDto);
            }
            if (userDto.ImageUrl != null)
                userDto.Image = await _fileService.SaveImageAsync(userDto.ImageUrl);
            user.FirstName = userDto.FirstName;
            user.LastName = userDto.LastName;
            user.Email = userDto.Email;
            user.PhoneNumber = userDto.PhoneNumber;
            user.Image = userDto.Image;
            user.Gender = userDto.Gender;
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach(var error in result.Errors)
                  ModelState.AddModelError("", error.Description);
                return View(userDto);
            }
            return RedirectToAction(nameof(Details));           
        }
        
    }
}
