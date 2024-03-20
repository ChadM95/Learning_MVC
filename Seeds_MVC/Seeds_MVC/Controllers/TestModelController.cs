using Microsoft.AspNetCore.Mvc;
using Seeds_MVC.Models;

namespace Seeds_MVC.Controllers
{
    public class TestModelController : Controller
    {
        public IActionResult TestIndex()
        {
            SeedsModel TestModel = new SeedsModel
            {
                Category = "Flowers",
                Name = "Lavender",
                Variety = "PurlpleTown",
                Description = "Bees Love it",
                Amount = 5
            };

            return View(TestModel);
        }
    }
}
