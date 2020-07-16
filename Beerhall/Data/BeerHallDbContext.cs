using System;
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
    }
}
