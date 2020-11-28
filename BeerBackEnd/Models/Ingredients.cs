using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBackEnd.Models
{
    public class Ingredients
    {
        public IList<Malt> malt { get; set; }
        public IList<Hop> hops { get; set; }
        public string yeast { get; set; }
    }
}