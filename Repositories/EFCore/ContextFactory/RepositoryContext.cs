using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Repositories.EFCore.ContextFactory
{
    public class RepositoryContext: IdentityDbContext<AppUser, AppRole,int>
    {
       public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }
       public DbSet<About> Abouts { get; set; }
       public DbSet<Comment> Comments { get; set; }
       public DbSet<Contact> Contacts { get; set; }
       public DbSet<Destination> Destinations { get; set; }
       public DbSet<Feature> Features { get; set; }
       public DbSet<Guide> Guides { get; set; }
       public DbSet<NewsLetter> NewsLetters { get; set; }
       public DbSet<SocialMedia> SocialMedias { get; set; }
       public DbSet<Testimonial> Testimonials { get; set; }
       public DbSet<Reservation> Reservations { get; set; }
    }
}
