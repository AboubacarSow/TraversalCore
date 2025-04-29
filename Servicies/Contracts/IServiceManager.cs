namespace Services.Contracts
{
    public interface IServiceManager
    {
        IDestinationService DestinationService { get; }
        IFeatureService FeatureService { get; }
        ITestimonialService TestimonialService { get; }
        IFileService FileService { get; }
        IReservationService ReservationService { get; }
        IGuideService GuideService { get; }
    }
}
