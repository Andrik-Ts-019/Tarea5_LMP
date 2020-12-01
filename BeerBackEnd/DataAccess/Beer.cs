using System;
using System.Collections.Generic;

namespace BeerBackEnd.DataAccess
{
    public partial class Beer
    {
        public Beer()
        {
            Food = new HashSet<Food>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Tagline { get; set; }
        public string FirstBrewed { get; set; }
        public string Description { get; set; }
        public float Abv { get; set; }
        public float Ibu { get; set; }
        public float TargetFg { get; set; }
        public float TargetOg { get; set; }
        public float Ebc { get; set; }
        public float Srm { get; set; }
        public float Ph { get; set; }
        public float AttenuationLevel { get; set; }
        public string BrewersTips { get; set; }
        public string ContributedBy { get; set; }

        public virtual ICollection<Food> Food { get; set; }
    }
}
