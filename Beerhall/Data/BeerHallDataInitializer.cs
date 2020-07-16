using System;
using BeerHall.Models.Domain;

namespace Beerhall.Data
{
    public class BeerHallDataInitializer
    {
        protected readonly BeerHallDbContext _dbContext;

        public BeerHallDataInitializer(BeerHallDbContext context)
        {
            _dbContext = context;
        }

        public void InitializeData()
        {
            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {
                Location bavikhove = new Location { Name = "Bavikhove", PostalCode = "8531" };
                Location roeselare = new Location { Name = "Roeselare", PostalCode = "8800" };
                Location puurs = new Location { Name = "Puurs", PostalCode = "2870" };
                Location leuven = new Location { Name = "Leuven", PostalCode = "3000" };
                Location oudenaarde = new Location { Name = "Oudenaarde", PostalCode = "9700" };
                Location affligem = new Location { Name = "Affligem", PostalCode = "1790" };

                Location[] locations = new Location[] { bavikhove, roeselare, puurs, leuven, oudenaarde, affligem };

                _dbContext.Locations.AddRange(locations);
                _dbContext.SaveChanges();
            }
        }
    }
}