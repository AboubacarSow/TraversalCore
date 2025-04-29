using DTOs.Validators.IdentityErrorDescribers;
using Entities.Models;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.ContextFactory;
using Repositories.EFCore.Contracts;
using Repositories.EFCore.Models;
using Services.Contracts;
using Services.Models;
using System.Reflection;

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
            services.AddScoped<IReservationRepository, ReservationRepository>();
        }
        public static void RegisterServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<IFileService, FileManager>();
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IGuideService, GuideManager>();
        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<RepositoryContext>()
             .AddErrorDescriber<CustomErrorDescriber>() ; 
            
            //configureApplicationCookie must be called right after AddIdentity
            //This overriding authorization Scheme
            services.ConfigureApplicationCookie(options =>
             {
                options.LoginPath = "/Account/SignIn";
                options.AccessDeniedPath = "/Error";
             });
        }
        public static void ConfigureFluentValidation(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation(config =>
            {
                config.DisableDataAnnotationsValidation = true;
            }).AddFluentValidationClientsideAdapters()
              .AddValidatorsFromAssemblyContaining<DTOs.AssemblyReference>();

        }
    }
}
