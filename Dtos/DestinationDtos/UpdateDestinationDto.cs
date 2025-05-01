using Microsoft.AspNetCore.Http;

namespace DTOs.DestinationDtos
{
    public class UpdateDestinationDto
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string? Image { get; set; }
        public IFormFile? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string DayNight { get; set; }
        public int Capacity { get; set; }
    }
}
