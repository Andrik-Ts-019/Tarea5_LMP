using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBackEnd.Models
{
    public class FoodPairing
    {
        public int id { get; set; }
        public int idBeer { get; set; }
        public string food_pairing { get; set; }
        public BeerDTO beer { get; set; }
    }
}