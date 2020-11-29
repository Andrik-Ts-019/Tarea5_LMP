using BeerBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBackEnd.Backend
{
    public class BeerSC
    {
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
                abv = 4.89,
                ibu = 7,
                target_fg = 1010,
                target_og = 1020,
                ebc = 20,
                srm = 10,
                ph = 3.5,
                attenuation_level = 67,
                food_pairing = new List<string>() { "La carnita asada", "La polaca", "Eres secreto de amor" },
                brewers_tips = "No tomar un día antes de entregar un trabajo de LMP",
                contributed_by = "Camelo Benito Amanda Cerena"
            });
            response.Add(new BeerDTO
            {
                id = 2
                name = "Indio",
                tagline = "La verde",
                first_brewed = "1970",
                description = "Una cerveza",
                abv = 6.89,
                ibu = 9,
                target_fg = 2010,
                target_og = 1050,
                ebc = 27.8,
                srm = 16.9,
                ph = 3,
                attenuation_level = 50,
                food_pairing = new List<string>() { "La carnita asada", "Coctel de camaron" },
                brewers_tips = "No tomar un día antes de entregar un trabajo de LMP",
                contributed_by = "Romeo Santos Sepulveda Esth"
            });
            response.Add(new BeerDTO
            {
                id = 3,
                name = "Corona",
                tagline = "La de México",
                first_brewed = "1567",
                description = "Una cerveza",
                abv = 1.90,
                ibu = 2,
                target_fg = 1000,
                target_og = 1000,
                ebc = 50,
                srm = 7.9,
                ph = 8,
                attenuation_level = 90,
                food_pairing = new List<string>() { "La carnita asada", "La polaca", "Todo" },
                brewers_tips = "No tomar un día antes de entregar un trabajo de LMP",
                contributed_by = "Guerrero Karlos Gerado Lourdes"
            });
            response.Add(new BeerDTO
            {
                id = 4,
                name = "BuzzLight",
                tagline = "Te hara volar",
                first_brewed = "2077",
                description = "Cyber Punk",
                abv = 9,
                ibu = 7,
                target_fg = 780,
                target_og = 2300,
                ebc = 83.1,
                srm = 2,
                ph = 2,
                attenuation_level = 34,
                food_pairing = new List<string>() { "La carnita asada", "Pastelillos espaciales" },
                brewers_tips = "No tomar un día antes de entregar un trabajo de LMP",
                contributed_by = "Dante Noemí Jazmín"
            });
            response.Add(new BeerDTO
            {
                id = 5,
                name = "Andrikiano",
                tagline = "La mejor de todas",
                first_brewed = "2020",
                description = "Profe no me repruebe",
                abv = 3,
                ibu = 2,
                target_fg = 890,
                target_og = 340,
                ebc = 59,
                srm = 8,
                ph = 6,
                attenuation_level = 90,
                food_pairing = new List<string>() { "La carnita asada", "Polaca", "Carnitas de LaCapital" },
                brewers_tips = "Ser proactivo",
                contributed_by = "Andrés de la Más Martinoly"
            });
            return response;
        }
    }
}