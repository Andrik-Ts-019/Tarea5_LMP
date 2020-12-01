using System;
using System.Collections.Generic;

namespace BeerBackEnd.DataAccess
{
    public partial class Food
    {
        public int Id { get; set; }
        public int IdBeer { get; set; }
        public string FoodPairing { get; set; }

        public virtual Beer IdBeerNavigation { get; set; }
    }
}
