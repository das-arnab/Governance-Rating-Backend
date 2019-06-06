﻿using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;
using In.GovernanceRating.Entities;
using Microsoft.EntityFrameworkCore;

namespace In.GovernanceRating.Repository
{
    /// <summary>
    /// TODO: Need to remove?
    /// </summary>
    public class CandidateContext: DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=blogging.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>();
        }
    }
}
