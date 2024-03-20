using Microsoft.AspNetCore.Mvc;

namespace Test_MVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            Models.TestModel Test = new Models.TestModel
            {
                Category = "Flowers",
                Name = "TestFlower",
                Description = "Great For Testing Models",
                Amount = 100
            };

            return View(Test);
        }
    }
}
