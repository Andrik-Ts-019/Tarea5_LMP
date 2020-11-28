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
            var response = new List<BeerDTO>();
            response.Add(new BeerDTO
            {
                id = 1,
                name = "Carta Blanca",
                tagline = "La de siempre",
                first_brewed = null,
                description = "Una cerveza bien buenota",
                image_url = null,
                abv = 4.89,
                ibu = 7,
                target_fg = 1010,
                target_og = 1020,
                ebc = 20,
                srm = 10,
                ph = 3.5,
                attenuation_level = 67,
                volume = null,
                boil_volume = null,
                method = null,
                ingredients = null,
                food_pairing = new List<string>() { "La carnita asada", "La polaca", "Eres secreto de amor" },
                brewers_tips = "No tomar un día antes de entregar un trabajo de LMP",
                contributed_by = "Camelo Benito Amanda Cerena"
            });
            return response;
        }
    }
}
