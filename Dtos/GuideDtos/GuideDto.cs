namespace DTOs.GuideDtos
{
    public record GuideDto
    {
        public int Id { get; init; }
        public string Image { get; init; }
        public string Description { get; init; }
        public string Name { get; init; }
    }
}
