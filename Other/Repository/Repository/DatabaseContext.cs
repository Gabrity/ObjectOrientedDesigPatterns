using Microsoft.EntityFrameworkCore;
using Repository.Entities;

namespace Repository.Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<Traveler> Travelers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Traveler>(entity =>
            {
                entity.ToTable("Traveler", "dbo");

                entity.HasKey(x => x.Id);
            });
        }
    }
}