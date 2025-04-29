namespace Entities.Models
{
    public class Guide
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SocialMedia> SocialMedias { get; set; }
    }
}
