namespace DTOs.ReservationDtos
{
    public record ReservationDto(int Id,int UserId,string Description, string Status, int Capacity);
   
}
