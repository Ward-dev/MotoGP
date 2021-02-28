using Microsoft.AspNetCore.Mvc;
using MotoGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Controllers
{
    public class InfoController : Controller
    {
       public IActionResult ListRaces()
        {
            ViewData["BannerNr"] = 0;
            ViewData["Title"] = "Races";
            return View();
        }

        public IActionResult BuildMap()
        {
            List<Race> races = new List<Race>()
            {
                new Race { RaceID = 1, X=517, Y=19, Name="Assen" },
                new Race { RaceID = 2, X = 859, Y = 249, Name = "Losail Circuit"},
                new Race { RaceID = 3, X = 194, Y = 428, Name = "Autodromo Termas de Rio Hondo"}

            };
            ViewData["BannerNr"] = 0;

            return View(races);
        }
    }
}
