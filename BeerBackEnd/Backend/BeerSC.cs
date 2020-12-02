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

        public BeerDTO updateProduct(BeerDTO newbeer)
        {
            var productInDataBase = getBeerById(newbeer.id);

            if (productInDataBase == null)
                return null;

            productInDataBase.name = newbeer.name;
            productInDataBase.tagline = newbeer.tagline;
            productInDataBase.first_brewed = newbeer.first_brewed;
            productInDataBase.description = newbeer.description;
            productInDataBase.abv = newbeer.abv;
            productInDataBase.ibu = newbeer.ibu;
            productInDataBase.target_fg = newbeer.target_fg;
            productInDataBase.target_og = newbeer.target_og;
            productInDataBase.ebc = newbeer.ebc;
            productInDataBase.srm = newbeer.srm;
            productInDataBase.ph = newbeer.ph;
            productInDataBase.attenuation_level = newbeer.attenuation_level;
            productInDataBase.food_pairing = newbeer.food_pairing;
            productInDataBase.brewers_tips = newbeer.brewers_tips;
            productInDataBase.contributed_by = newbeer.contributed_by;

            return productInDataBase;
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