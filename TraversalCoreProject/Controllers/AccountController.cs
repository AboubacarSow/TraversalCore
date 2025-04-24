using AspNetCoreGeneratedDocument;
using AutoMapper;
using DTOs.AccountDtos;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;

        public AccountController(UserManager<AppUser> userManager, IMapper mapper,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegistrationDto userDto)
        {
            if (!ModelState.IsValid)
                return View(userDto);
            var user = _mapper.Map<AppUser>(userDto);
            var result =await  _userManager.CreateAsync(user, userDto.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                    ModelState.AddModelError("", error.Description);
                return View(userDto);
            }
            return RedirectToAction(nameof(SignIn));
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        } 
        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginDto userDto,string returnUrl)
        {
            if (!ModelState.IsValid)
                return View(userDto);
            var result = await _signInManager.PasswordSignInAsync(userDto.UserName, userDto.Password,
                false, true);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "kullanıcı Adı Veya Şifre Hatalıdır");
                return View(userDto);
            }
            if (returnUrl != null)
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction(actionName:"Index",controllerName:"Destination");
        }
    }
}
