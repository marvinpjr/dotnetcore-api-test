using Microsoft.EntityFrameworkCore;
using StatKeeper.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatKeeper.Api.EntityFramework
{
    public class StatKeeperContext: DbContext
    {
        public StatKeeperContext(DbContextOptions<StatKeeperContext> options): base(options) {}

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().ToTable("Teams");
            modelBuilder.Entity<Player>().ToTable("Players");
        }
    }
}
