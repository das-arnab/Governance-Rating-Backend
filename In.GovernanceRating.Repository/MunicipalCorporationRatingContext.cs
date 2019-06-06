using System;
using System.Collections.Generic;
using System.Text;
using In.GovernanceRating.Entities;
using Microsoft.EntityFrameworkCore;

namespace In.GovernanceRating.Repository
{
    /// <summary>
    /// Context related to rating of Municipal Corporation administrative body.
    /// </summary>
    public class MunicipalCorporationRatingContext: DbContext
    {
        public DbSet<MunicipalCorporation> MunicipalCorporations { get; set; }

        public DbSet<MunicipalCorporationWard> MunicipalCorporationWards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
        }
    }
}
