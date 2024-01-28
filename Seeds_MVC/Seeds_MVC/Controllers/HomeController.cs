using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Seeds_MVC.Models;

namespace Seeds_MVC.Controllers;

public class HomeController : Controller
{ 

    public IActionResult Home()
    {
        return View();
    }

    
}

