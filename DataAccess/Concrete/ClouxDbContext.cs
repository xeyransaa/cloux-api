using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ClouxDbContext: DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer(@"Server = DESKTOP-DVU2OKM\SQLEXPRESS;Database=ClouxDb;Trusted_Connection=true;TrustServerCertificate=True;MultipleActiveResultSets=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>()
                .Property(e => e.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Game>()
                .Property(e => e.DateCreated)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<SocialMedia>().HasData(
            new SocialMedia { Id = 1, Name = "Facebook", Link = "https://www.facebook.com" },
            new SocialMedia { Id = 2, Name = "Twitter", Link = "https://www.twitter.com" },
            new SocialMedia { Id = 3, Name = "Google Plus", Link = "https://www.plus.google.com"},
            new SocialMedia { Id = 4, Name = "Youtube", Link = "https://www.youtube.com"},
            new SocialMedia { Id = 5, Name = "Instagram", Link = "https://www.instagram.com" },
            new SocialMedia { Id = 6, Name = "Twitch", Link = "https://www.twitch.tv"}
        );

            modelBuilder.Entity<GameCategory>()
                .HasOne(g => g.Game)
                .WithMany(gc => gc.GameCategories)
                .HasForeignKey(c => c.GameId);

            modelBuilder.Entity<GameCategory>()
                .HasOne(g => g.Category)
                .WithMany(gc => gc.GameCategories)
                .HasForeignKey(c => c.CategoryId);

           

            modelBuilder.Entity<GamePlatform>()
                .HasOne(gp => gp.Platform)
                .WithMany(gp => gp.GamePlatforms)
                .HasForeignKey(gp => gp.PlatformId);

            modelBuilder.Entity<GamePlatform>()
                .HasOne(gp => gp.Game)
                .WithMany(gp => gp.GamePlatforms)
                .HasForeignKey(gp => gp.GameId);

            modelBuilder.Entity<GameLanguageTypeL>()
                .HasOne(gp => gp.Game)
                .WithMany(gp => gp.GameLanguageTypeLs)
                .HasForeignKey(gp => gp.GameId);

            modelBuilder.Entity<GameLanguageTypeL>()
                .HasOne(gp => gp.LanguageTypeL)
                .WithMany(gp => gp.GameLanguageTypeLs)
                .HasForeignKey(gp => gp.LanguageTypeLId);

            modelBuilder.Entity<LanguageTypeL>()
                .HasOne(gp => gp.Language)
                .WithMany(gp => gp.LanguageTypeLs)
                .HasForeignKey(gp => gp.LanguageId);

            modelBuilder.Entity<LanguageTypeL>()
                .HasOne(gp => gp.LanguageType)
                .WithMany(gp => gp.LanguageTypeLs)
                .HasForeignKey(gp => gp.LanguageTypeId);

        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<GameCategory> GameCategories { get; set; }
        public DbSet<GamePlatform> GamePlatforms { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogsCategories { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<GameDeveloper> GameDevelopers { get; set; }
        public DbSet<GameLanguageTypeL> GameLanguageTypeLs { get; set; }
        public DbSet<LanguageTypeL> LanguageTypeLs { get; set; }
        public DbSet<LanguageType> LanguageTypes { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<OSReqs> OSReqs { get; set; }
        public DbSet<OS> OSs { get; set; }
        public DbSet<SystemReqs> SystemReqs { get; set; }

    }
}
