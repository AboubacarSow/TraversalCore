namespace Entities.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MapUrl { get; set; }
        public bool Status { get; set; }
    }
}
