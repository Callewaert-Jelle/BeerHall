using System;
namespace BeerHall.Models.Domain
{
    public class Beer
    {
        #region properties
        public int BeerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? AlcoholByVolume { get; set; }
        public bool AlcoholKnown => AlcoholByVolume.HasValue;
        public decimal Price { get; set; }
        #endregion

        #region constructors
        protected Beer()
        {
        }
        public Beer(string name): this()
        {
            Name = name;
        }
        #endregion
    }
}
