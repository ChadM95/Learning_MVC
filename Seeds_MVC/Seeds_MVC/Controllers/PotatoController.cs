using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Seeds_MVC.Controllers
{
    public class PotatoController : Controller
    {
        
        public IActionResult BlightResistant()
        {
            return View();
        }

        public IActionResult MainCrop()
        {
            return View();
        }
    }
}

