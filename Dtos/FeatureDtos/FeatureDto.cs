namespace DTOs.FeatureDtos
{
    public record FeatureDto(int Id,string Name,string Description,
        string Image,bool IsMainFeature,bool Status);

   
}
