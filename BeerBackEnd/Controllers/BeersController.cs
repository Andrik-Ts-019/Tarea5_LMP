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
        public BeerDTO getProductById(int id)
        {
            return new BeerSC().getAllBeers().Where(w => w.id == id).FirstOrDefault();
        }
    }
}
