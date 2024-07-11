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
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
    }
}
