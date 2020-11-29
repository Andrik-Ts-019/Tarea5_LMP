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
        // .../api/beers/getAllBeers
        [HttpGet]
        public List<BeerDTO> getAllBeers()
        {
            return new BeerSC().getAllBeers();
        }

        // .../api/beers/getBeerById?id=#
        [HttpGet]
        public BeerDTO getBeerById(int id)
        {
            return new BeerSC().getAllBeers().Where(w => w.id == id).FirstOrDefault();
        }

        // .../api/beers/getBeerByName?name=#
        [HttpGet]
        public BeerDTO getBeerByName(string name)
        {
            return new BeerSC().getAllBeers().Where(w => w.name == name).FirstOrDefault();
        }

        // .../api/beers/getBeerRandom
        [HttpGet]
        public BeerDTO getBeerRandom()
        {
            var beers = new BeerSC().getAllBeers();
            Random r = new Random();
            return beers[r.Next(0,beers.Count)];
        }

        // .../api/beers/getBeerAttenuation?level=#
        [HttpGet]
        public BeerDTO getBeerAttenuation(int level)
        {
            return new BeerSC().getAllBeers().Where(w => w.attenuation_level == level).FirstOrDefault();
        }

        [HttpPost]
        public List<BeerDTO> addBeer([FromBody] BeerDTO newbeer)
        {
            var beers = new BeerSC().getAllBeers();
            beers.Add(newbeer);
            return new BeerSC().getAllBeers();
        }
    }
}
