using Services.Contracts;

namespace Services.Models
{
    public class ServiceManager : IServiceManager
    {
        private readonly IDestinationService _destinationService;
        private readonly IFeatureService _featureService;
        private readonly ITestimonialService _testimonialService;
        private readonly IFileService _fileService;
        private readonly IReservationService _reservationService;

        public ServiceManager(IDestinationService destinationService, IFeatureService featureService,
            ITestimonialService testimonialService, IFileService fileService, IReservationService reservationService)
        {
            _destinationService = destinationService;
            _featureService = featureService;
            _testimonialService = testimonialService;
            _fileService = fileService;
            _reservationService = reservationService;
        }
        public IDestinationService DestinationService => _destinationService;
        public IFeatureService FeatureService => _featureService;
        public ITestimonialService TestimonialService => _testimonialService;
        public IFileService FileService => _fileService;

        public IReservationService ReservationService => _reservationService;
    }
}
