namespace Entities.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string? Icon { get; set; }
        public string? Name { get; set; }
        public string AccountUrl { get; set; }
        public int GuideId { get; set; }
        public virtual Guide? Guide { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
