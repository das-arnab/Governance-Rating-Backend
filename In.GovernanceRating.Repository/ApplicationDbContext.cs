using In.GovernanceRating.Entities;
using Microsoft.EntityFrameworkCore;

namespace In.GovernanceRating.Repository
{
    /// <summary>
    /// Contains entities which have application wide contexts.
    /// </summary>
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }
        
        public DbSet<DevelopmentActivity> DevelopmentActivities { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
