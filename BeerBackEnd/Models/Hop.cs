using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBackEnd.Models
{
    public class Hop
    {
        public string name { get; set; }
        public Amount amount { get; set; }
        public string add { get; set; }
        public string attribute { get; set; }
    }
}