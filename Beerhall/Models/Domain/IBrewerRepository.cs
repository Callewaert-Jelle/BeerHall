using BeerHall.Models.Domain;
using System.Collections.Generic;

namespace Beerhall.Models.Domain
{
    public interface IBrewerRepository
    {
        Brewer GetBy(int id);
        IEnumerable<Brewer> GetAll();

        void SaveChanges();
    }
}
