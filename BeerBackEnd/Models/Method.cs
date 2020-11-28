using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBackEnd.Models
{
    public class Method
    {
        public IList<MashTemp> mash_temp { get; set; }
        public Fermentation fermentation { get; set; }
        public object twist { get; set; }
    }
}