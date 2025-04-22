namespace Entities.Models
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsMainFeature { get; set; }
        public bool Status { get; set; }
    }
}
