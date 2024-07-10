using Learning_1.Models;
using Microsoft.EntityFrameworkCore;

namespace SecondCode.Data
{
    public class DataContextEF : DbContext
    {
        public DbSet<Exercise>? Exercise { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                // Pass the connection, in case of failure, retry
                options.UseSqlServer(
                    "Server=localhost;Database=ExerciseDatabase;" +
                    "TrustServerCertificate=true;Trusted_Connection=true;",
                    options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TutorialAppSchema");
            modelBuilder.Entity<Exercise>();
        }
        
    }
}
