using System;
using System.Collections.Generic;
using System.Text;
using In.GovernanceRating.Entities;
using Microsoft.EntityFrameworkCore;

namespace In.GovernanceRating.Repository
{
    /// <summary>
    /// Contains entities which have application wide contexts.
    /// </summary>
    public class ApplicationContext: DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }
        
        public DbSet<DevelopmentActivity> DevelopmentActivities { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
