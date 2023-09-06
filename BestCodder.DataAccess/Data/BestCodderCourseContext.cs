using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BestCodder.DataAccess.Data
{
    public class BestCodderCourseContext :IdentityDbContext<IdentityUser>
    {
      

        public BestCodderCourseContext(DbContextOptions<BestCodderCourseContext> options) 
            : base(options)
        { 
        }

       // public DbSet<IdentityUserLogin> AspNetUsers { get; set; }
        public DbSet<IdentityUser> Users { get; set; }


       // public DbSet<NewUsers> newUsers { get; set; }

        public DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
