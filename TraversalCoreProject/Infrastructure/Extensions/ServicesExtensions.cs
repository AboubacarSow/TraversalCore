using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;
using Repositories.EFCore.Models;
using Services.Contracts;
using Services.Models;

namespace TraversalCoreProject.Infrastructure.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureRepositoryContext(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("sqlConnection"));
            });
        }
        public static void RegisterRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IDestinationRepository, DestinationRepository>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddScoped<IGuideRepository, GuideRepository>();
            services.AddScoped<INewsLetterRepository, NewsLetterRepository>();
            services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
        }
        public static void RegisterServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
        }
    }
}
