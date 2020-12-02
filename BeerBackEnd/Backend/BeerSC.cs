using BeerBackEnd.DataAccess;
using BeerBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBackEnd.Backend
{
    public class BeerSC
    {
        public BeersContext dataBase = new BeersContext();
        
        public List<BeerDTO> getAllBeers()
        {
            var response = new List<BeerDTO>();
            response = dataBase.Beer.Select(s => new BeerDTO
            {
                id = s.Id,
                name = s.Name,
                tagline = s.Tagline,
                first_brewed = s.FirstBrewed,
                description = s.Description,
                abv = s.Abv,
                ibu = s.Ibu,
                target_fg = s.TargetFg,
                target_og = s.TargetOg,
                ebc = s.Ebc,
                srm = s.Srm,
                ph = s.Ph,
                attenuation_level = s.AttenuationLevel,
                food_pairing = (from x in s.Food where x.Id==s.Id select x.FoodPairing).ToList(),
                brewers_tips = s.BrewersTips,
                contributed_by = s.ContributedBy
            }).ToList();

            return response;
        }

        public BeerDTO getBeerById(int id)
        {
            return getAllBeers().Where(w => w.id == id).FirstOrDefault();
        }

        public BeerDTO updateBeer(BeerDTO newbeer)
        {
            var beerInDataBase = getBeerById(newbeer.id);

            if (beerInDataBase == null)
                return null;

            beerInDataBase.name = newbeer.name;
            beerInDataBase.tagline = newbeer.tagline;
            beerInDataBase.first_brewed = newbeer.first_brewed;
            beerInDataBase.description = newbeer.description;
            beerInDataBase.abv = newbeer.abv;
            beerInDataBase.ibu = newbeer.ibu;
            beerInDataBase.target_fg = newbeer.target_fg;
            beerInDataBase.target_og = newbeer.target_og;
            beerInDataBase.ebc = newbeer.ebc;
            beerInDataBase.srm = newbeer.srm;
            beerInDataBase.ph = newbeer.ph;
            beerInDataBase.attenuation_level = newbeer.attenuation_level;
            beerInDataBase.food_pairing = newbeer.food_pairing;
            beerInDataBase.brewers_tips = newbeer.brewers_tips;
            beerInDataBase.contributed_by = newbeer.contributed_by;

            return beerInDataBase;
        }

        public bool deleteBeer(int id)
        {
            try
            {
                var allBeers = getAllBeers();
                var beerToDelete = getBeerById(id);
                
                allBeers.Remove(beerToDelete);
                //DataContext.Beers.Remove;
                //DataContext.SaveChanges;
            }
            catch(Exception)
            {
                return false;
            }
            
            return true;
        }

    }
}