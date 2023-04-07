using Core.Security.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Persistance.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Core.Security.Entities.OperationClaim> OperationClaims { get; set; }
        public DbSet<Core.Security.Entities.UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }


        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>(a =>
            {
                a.ToTable("Languages").HasKey(k => k.Id);
                a.Property(p=>p.Id).HasColumnName("Id");
                a.Property(p=>p.Name).HasColumnName("Name");
            });

            modelBuilder.Entity<Technology>(a => { 
                a.ToTable("Technologies").HasKey(k=>k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.LanguageId).HasColumnName("LanguageId");
                a.Property(p => p.Name).HasColumnName("Name");

            });


           

            Language[] languageEntitySeeds = { new(1,"C#"), new(2, "Java"), new(3, "Python") };
            modelBuilder.Entity<Language>().HasData(languageEntitySeeds);

            Technology[] technologyEntitySeeds = { new(1,1,"Asp.NET"), new(2, 2,"Spring"), new(3,2, "JSP") };
            modelBuilder.Entity<Technology>().HasData(technologyEntitySeeds);


        }
    }
}
