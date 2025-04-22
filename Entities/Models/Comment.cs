namespace Entities.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Body { get; set; }
        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; }
        public string AuthorName { get; set; }
        public string? AuthorEmail { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Status { get; set; }
    }
}
