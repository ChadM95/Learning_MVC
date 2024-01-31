using Microsoft.AspNetCore.Mvc;

namespace Seeds_MVC.Controllers;

public class SeedsController : Controller
{
    // GET
    public IActionResult FlowerSeeds()
    {
        return View();
    }
}