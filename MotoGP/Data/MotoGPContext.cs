using Microsoft.EntityFrameworkCore;
using MotoGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Data
{
    public class MotoGPContext:DbContext
    {
        public MotoGPContext(DbContextOptions<MotoGPContext> options):base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Rider> Riders { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Race> Races { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().ToTable("Team").Property(p=>p.TeamID).ValueGeneratedNever();
            modelBuilder.Entity<Rider>().ToTable("Rider");
            modelBuilder.Entity<Country>().ToTable("Country").Property(p=>p.CountryID).ValueGeneratedNever();
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<Race>().ToTable("Race");
        }
        //tretre
    }
}
