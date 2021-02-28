using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult OrderTicket()
        {
            ViewData["BannerNr"] = 3;

            return View();
        }

        public IActionResult ConfirmOrder()
        {
            ViewData["BannerNr"] = 3;

            return View();
        }

    }
}
