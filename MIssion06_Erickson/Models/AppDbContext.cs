using Microsoft.EntityFrameworkCore;

namespace MIssion06_Erickson.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Example of Fluent API if needed
            modelBuilder.Entity<Movie>()
                .Property(m => m.Notes)
                .HasMaxLength(25);
        }
    }
}
