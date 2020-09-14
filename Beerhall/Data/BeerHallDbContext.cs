using System;
using Beerhall.Data.Mapper;
using Beerhall.Data.Mapping;
using BeerHall.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Beerhall.Data
{
    public class BeerHallDbContext: DbContext
    {
        public DbSet<Brewer> Brewers { get; set; }
        public DbSet<Location> Locations { get; set; }

        public BeerHallDbContext(DbContextOptions<BeerHallDbContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new BrewerConfiguration());
        }
    }
}
