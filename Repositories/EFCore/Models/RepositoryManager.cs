using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;

namespace Repositories.EFCore.Models
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IAboutRepository _about;

        private readonly IContactRepository _contact;
               
        private readonly IDestinationRepository _destination;
                 
        private readonly IFeatureRepository _feature ;

        private readonly IGuideRepository _guide;
                 
        private readonly INewsLetterRepository _newsLetter ;
                 
        private readonly ISocialMediaRepository _socialMedia;
                 
        private readonly ITestimonialRepository _testimonial ;

        public RepositoryManager(IAboutRepository about, IContactRepository contact,
            IDestinationRepository destination, IFeatureRepository feature,
            IGuideRepository guide, INewsLetterRepository newsLetter,
            ISocialMediaRepository socialMedia, ITestimonialRepository testimonial,
            RepositoryContext context)
        {
            _about = about;
            _contact = contact;
            _destination = destination;
            _feature = feature;
            _guide = guide;
            _newsLetter = newsLetter;
            _socialMedia = socialMedia;
            _testimonial = testimonial;
            _context = context;
        }

        public IAboutRepository About => _about;

        public IContactRepository Contact => _contact;

        public IDestinationRepository Destination => _destination;

        public IFeatureRepository Feature => _feature;

        public IGuideRepository Guide => _guide;

        public INewsLetterRepository NewsLetter => _newsLetter;

        public ISocialMediaRepository SocialMedia => _socialMedia;

        public ITestimonialRepository Testimonial => _testimonial;

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
        
    }
}
