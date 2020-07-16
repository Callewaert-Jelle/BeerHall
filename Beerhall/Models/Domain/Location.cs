using System;
namespace BeerHall.Models.Domain
{
    public class Location
    {
        #region properties
        public string PostalCode { get; set; }
        public string Name { get; set; }
        #endregion

        #region constructors
        public Location()
        {
        }
        #endregion
    }
}
