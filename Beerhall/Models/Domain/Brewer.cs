using System;
using System.Collections.Generic;

namespace BeerHall.Models.Domain
{
    public class Brewer
    {
        #region properties
        public int BrewerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public DateTime? DateEstablished { get; set; }
        public string Street { get; set; }
        public int? Turnover { get; set; }
        public ICollection<Beer> Beers { get; set; }
        public int NrOfBeers => Beers.Count;
        public Location Location { get; set; }
        #endregion

        #region constructors
        public Brewer()
        {
            Beers = new HashSet<Beer>();
        }
        public Brewer(string name, Location location, string street)
        {
            Beers = new HashSet<Beer>();
            Name = name;
            Location = location;
            Street = street;
        }
        #endregion
    }
}
