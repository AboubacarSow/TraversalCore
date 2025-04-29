using DTOs.SocialMediaDtos;

namespace TraversalCoreProject.Models
{
    public class ProfileInfoViewModel
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public List<SocialMediaDto> SocialMedias { get; set; }
    }


}
