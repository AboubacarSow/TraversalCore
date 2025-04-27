using Microsoft.AspNetCore.Http;

namespace DTOs.AccountDtos
{
    public class UserForUpdateDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public IFormFile? ImageUrl { get; set; }
        public string? Image { get; set; }
        public string? PhoneNumber { get; set; }
        public bool Gender { get; set; }
        public string? Password { get; set; }
    }

}
