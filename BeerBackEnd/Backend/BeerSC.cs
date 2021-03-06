﻿using BeerBackEnd.DataAccess;
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

        public IQueryable<Beer> getAllBeerFromDB()
        {
            return dataBase.Beer;
        }

        public List<BeerDTO> getAllBeers()
        {
            var response = new List<BeerDTO>();
            response = getAllBeerFromDB().Select(s => new BeerDTO
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
                food_pairing = null, //Sorry sé que después debo encontrar como hacerlo (from x in s.Food where x.Id==s.Id select x.FoodPairing).ToList(),
                brewers_tips = s.BrewersTips,
                contributed_by = s.ContributedBy
            }).ToList();

            return response;
        }

        public Beer getBeerById(int id)
        {
            return getAllBeerFromDB().Where(w => w.Id == id).FirstOrDefault();
        }

        public Beer getBeerByName(string name)
        {
            return getAllBeerFromDB().Where(w => w.Name == name).FirstOrDefault();
        }

        public List<BeerDTO> getBeerByAttenuation(float level)
        {
            var response = new List<BeerDTO>();

            response = getAllBeerFromDB().Where(w => w.AttenuationLevel == level).Select(s => new BeerDTO
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
                food_pairing = null, //Sorry sé que después debo encontrar como hacerlo (from x in s.Food where x.Id==s.Id select x.FoodPairing).ToList(),
                brewers_tips = s.BrewersTips,
                contributed_by = s.ContributedBy
            }).ToList();

            return response;
        }

        public Beer updateBeer(BeerDTO newbeer)
        {
            var beerInDataBase = getBeerById(newbeer.id);

            if (beerInDataBase == null)
                return null;

            beerInDataBase.Name = newbeer.name;
            beerInDataBase.Tagline = newbeer.tagline;
            beerInDataBase.FirstBrewed = newbeer.first_brewed;
            beerInDataBase.Description = newbeer.description;
            beerInDataBase.Abv = newbeer.abv;
            beerInDataBase.Ibu = newbeer.ibu;
            beerInDataBase.TargetFg = newbeer.target_fg;
            beerInDataBase.TargetOg = newbeer.target_og;
            beerInDataBase.Ebc = newbeer.ebc;
            beerInDataBase.Srm = newbeer.srm;
            beerInDataBase.Ph = newbeer.ph;
            beerInDataBase.AttenuationLevel = newbeer.attenuation_level;
            beerInDataBase.Food = null; //Sorry sé que después debo encontrar como hacerlo
            beerInDataBase.BrewersTips = newbeer.brewers_tips;
            beerInDataBase.ContributedBy = newbeer.contributed_by;

            dataBase.SaveChanges();

            return beerInDataBase;
        }

        public Beer addBeer(BeerDTO newbeer)
        {
            var newBeerInDB = new Beer();

            newBeerInDB.Name = newbeer.name;
            newBeerInDB.Tagline = newbeer.tagline;
            newBeerInDB.FirstBrewed = newbeer.first_brewed;
            newBeerInDB.Description = newbeer.description;
            newBeerInDB.Abv = newbeer.abv;
            newBeerInDB.Ibu = newbeer.ibu;
            newBeerInDB.TargetFg = newbeer.target_fg;
            newBeerInDB.TargetOg = newbeer.target_og;
            newBeerInDB.Ebc = newbeer.ebc;
            newBeerInDB.Srm = newbeer.srm;
            newBeerInDB.Ph = newbeer.ph;
            newBeerInDB.AttenuationLevel = newbeer.attenuation_level;
            newBeerInDB.Food = null; //Sorry sé que después debo encontrar como hacerlo
            newBeerInDB.BrewersTips = newbeer.brewers_tips;
            newBeerInDB.ContributedBy = newbeer.contributed_by;

            dataBase.Beer.Add(newBeerInDB);
            dataBase.SaveChanges();
            
            return newBeerInDB;
        }

        public bool deleteBeer(int id)
        {
            try
            {
                var beerToDelete = getBeerById(id);
                
                dataBase.Beer.Remove(beerToDelete);
                dataBase.SaveChanges();
            }
            catch(Exception)
            {
                return false;
            }
            
            return true;
        }

    }
}