using DiplomentProekt.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ImageGallery.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }
        public DbSet<Picture>Pictures{get;set;}
        public DbSet<Gallery>Galleries{get;set;}
        public DbSet<Category>Categories{get;set;}
        public DbSet<AppUser>AppUsers{get;set;}
        public DbSet<Rating>Ratings{get;set;}
    }
}