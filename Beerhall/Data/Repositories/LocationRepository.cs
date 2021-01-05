using Beerhall.Models.Domain;
using BeerHall.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Beerhall.Data.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly BeerHallDbContext _context;
        private readonly DbSet<Location> _locations;

        public LocationRepository(BeerHallDbContext context)
        {
            _context = context;
            _locations = context.Locations;
        }
        public IEnumerable<Location> GetAll()
        {
            return _locations.ToList();
        }

        public Location GetBy(string postalCode)
        {
            return _locations.FirstOrDefault(l => l.PostalCode == postalCode);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
