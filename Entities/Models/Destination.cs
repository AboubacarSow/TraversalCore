namespace Entities.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public string City { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string DayNight { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
