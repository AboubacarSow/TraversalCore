using Services.Contracts;

namespace Services.Models
{
    public class ServiceManager : IServiceManager
    {
        private readonly IDestinationService _destinationService;
        private readonly IFeatureService _featureService;
        private readonly ITestimonialService _testimonialService;

        public ServiceManager(IDestinationService destinationService, IFeatureService featureService, ITestimonialService testimonialService)
        {
            _destinationService = destinationService;
            _featureService = featureService;
            _testimonialService = testimonialService;
        }
        public IDestinationService DestinationService => _destinationService;

        public IFeatureService FeatureService => _featureService;

        public ITestimonialService TestimonialService => _testimonialService;
    }
}
