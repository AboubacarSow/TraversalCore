using AutoMapper;
using DTOs.AccountDtos;
using Entities.Models;

namespace TraversalCoreProject.Utilities.AutoMapper
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<UserRegistrationDto, AppUser>();
        }
    }
}
