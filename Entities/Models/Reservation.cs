namespace Entities.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual AppUser User { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; }
        public string? Status { get; set; }
    }
}
