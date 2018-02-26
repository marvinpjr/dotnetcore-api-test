using Microsoft.EntityFrameworkCore;
using StatsKeeper.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsKeeper.Api.EntityFramework
{
    public class StatKeeperContext: DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=StatKeeperDbServer;Database=StatKeeper;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasMany(t => t.Players)
                .WithOne();

            modelBuilder.Entity<Player>()
                .HasMany(p => p.Teams)
                .WithOne();
        }
    }
}
