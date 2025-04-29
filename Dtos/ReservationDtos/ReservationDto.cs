using DTOs.DestinationDtos;

namespace DTOs.ReservationDtos
{
    public record ReservationDto(int Id,int UserId,string Description, string Status, int Capacity,int DestinationId,
        DestinationDto Destination,DateTime Date);
   
}
