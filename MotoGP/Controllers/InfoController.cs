using Microsoft.AspNetCore.Mvc;
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
    }
}
