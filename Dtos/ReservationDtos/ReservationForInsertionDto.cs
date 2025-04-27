namespace DTOs.ReservationDtos
{
    public class ReservationForInsertionDto
    {
        public string Description { get; set; }
        public string? Status { get; set; }
        public int? UserId { get; set; }
        public int Capacity { get; set; }
        public int DestinationId { get; set; }
        public DateTime Date { get; set; }

    }
   


}
