using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Image { get; set; }
        public bool Gender { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

    }



}
