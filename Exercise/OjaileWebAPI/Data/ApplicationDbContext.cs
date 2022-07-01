using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OjaileWebAPI.Model;

namespace OjaileWebAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Country>(c =>
            {
                c.HasKey("Id");//c.Haskey(p =>p.Id);
                
            });
            //builder.Entity<Country>(c =>
            //{
            //    c.HasNoKey();
            //});


        }
    }
}
