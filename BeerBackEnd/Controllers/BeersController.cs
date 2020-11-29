using BeerBackEnd.Backend;
using BeerBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BeerBackEnd.Controllers
{
    public class BeersController : ApiController
    {
        [HttpGet]
        public List<BeerDTO> getAllBeers()
        {
            return new BeerSC().getAllBeers();
        }

        [HttpGet]
        public BeerDTO getBeerById(int id)
        {
            return new BeerSC().getAllBeers().Where(w => w.id == id).FirstOrDefault();
        }

        [HttpGet]
        public BeerDTO getBeerByName(string name)
        {
            return new BeerSC().getAllBeers().Where(w => w.name == name).FirstOrDefault();
        }

        [HttpGet]
        public BeerDTO getBeerRamdom()
        {
            var beers = new BeerSC().getAllBeers();
            Random r = new Random();
            return beers[r.Next(1,beers.Count)];
        }

        [HttpGet]
        public BeerDTO getBeerAttenuation(int level)
        {
            return new BeerSC().getAllBeers().Where(w => w.attenuation_level == level).FirstOrDefault();
        }
    }
}
