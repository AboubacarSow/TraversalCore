using Microsoft.AspNetCore.Http;

namespace DTOs.DestinationDtos
{
    public record CreateDestinationDto(string City,
        decimal Price, IFormFile ImageUrl,
        string Description, string DayNight, int Capacity)
    { 
        public string ? Image { get; set; }
    }

}
