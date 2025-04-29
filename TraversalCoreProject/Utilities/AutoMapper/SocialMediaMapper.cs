using AutoMapper;
using DTOs.SocialMediaDtos;
using Entities.Models;

namespace TraversalCoreProject.Utilities.AutoMapper
{
    public class SocialMediaMapper: Profile
    {
        public SocialMediaMapper()
        {
            CreateMap<SocialMedia, SocialMediaDto>();
        }
    }
}
