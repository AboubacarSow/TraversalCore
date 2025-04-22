namespace Services.Contracts
{
    public interface IServiceManager
    {
        IDestinationService DestinationService { get; }
        IFeatureService FeatureService { get; }
        ITestimonialService TestimonialService { get; }
    }
}
