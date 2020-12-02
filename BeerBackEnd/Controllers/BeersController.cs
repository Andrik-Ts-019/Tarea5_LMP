﻿using BeerBackEnd.Backend;
using BeerBackEnd.DataAccess;
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
        public Beer getBeerById(int id)
        {
            return new BeerSC().getBeerById(id);
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
        public List<BeerDTO> getBeerAttenuation(int level)
        {
            return new BeerSC().getAllBeers().Where(w => w.attenuation_level == level).ToList();
        }

        // .../api/beers/addBeer
        [HttpPost]
        public BeerDTO addBeer([FromBody] BeerDTO newbeer)
        {
            var beers = new BeerSC().getAllBeers();
            beers.Add(newbeer);
            return newbeer;
        }

        // .../api/beers/updateBeer
        [HttpPut]
        public Beer updateBeer([FromBody] BeerDTO newbeer)
        {
            var beerUpdate = new BeerSC().updateBeer(newbeer);
            return beerUpdate;
        }

        // .../api/beers/deleteBeer?id=#
        [HttpDelete]
        public bool deleteBeer(int id)
        {
            var beerDelete = new BeerSC().deleteBeer(id);
            return beerDelete;
        }
    }
}
