using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBackEnd.Models
{
    public class BeerDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
        public string first_brewed { get; set; }
        public string description { get; set; }
        public double abv { get; set; }
        public double ibu { get; set; }
        public double target_fg { get; set; }
        public double target_og { get; set; }
        public double ebc { get; set; }
        public double srm { get; set; }
        public double ph { get; set; }
        public double attenuation_level { get; set; }
        public string brewers_tips { get; set; }
        public string contributed_by { get; set; }
        public ICollection<FoodPairing> food_pairing { get; set; }
    }
}