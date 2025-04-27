namespace Repositories.EFCore.Contracts
{
    public interface IRepositoryManager
    {
        IAboutRepository About { get; }
        IContactRepository Contact { get; }
        IDestinationRepository Destination { get; }
        IFeatureRepository Feature { get; }
        IGuideRepository Guide { get; }
        INewsLetterRepository NewsLetter { get; }
        ISocialMediaRepository SocialMedia { get; }
        ITestimonialRepository Testimonial { get; }
        IReservationRepository Reservation { get; }
        Task SaveChangesAsync();
    }
}
