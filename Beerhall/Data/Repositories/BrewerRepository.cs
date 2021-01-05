using Beerhall.Models.Domain;
using BeerHall.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Beerhall.Data.Repositories
{
    public class BrewerRepository : IBrewerRepository
    {
        private readonly BeerHallDbContext _context;
        private readonly DbSet<Brewer> _brewers;

        public BrewerRepository(BeerHallDbContext context)
        {
            _context = context;
            _brewers = context.Brewers;
        }

        public IEnumerable<Brewer> GetAll()
        {
            return _brewers.Include(b => b.Location).ToList();
        }
        public Brewer GetBy(int id)
        {
            return _brewers.Include(b => b.Location).SingleOrDefault(b => b.BrewerId == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
