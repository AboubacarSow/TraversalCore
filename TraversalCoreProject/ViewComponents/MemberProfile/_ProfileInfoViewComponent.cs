using AutoMapper;
using DTOs.SocialMediaDtos;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.ViewComponents.MemberProfile
{
    public class _ProfileInfoViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public _ProfileInfoViewComponent(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var profile = new ProfileInfoViewModel
            {
                FullName = String.Concat(user?.FirstName, " ", user?.LastName),
                PhoneNumber = user?.PhoneNumber!,
                Location = user?.Location!,
                Email=user?.Email,
                SocialMedias = _mapper.Map<List<SocialMediaDto>>(user?.SocialMedias)
            };
            return View(profile);
        }
    }
}
