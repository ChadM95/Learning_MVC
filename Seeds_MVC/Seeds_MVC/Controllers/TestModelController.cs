using Microsoft.AspNetCore.Mvc;

namespace Seeds_MVC.Controllers
{
    public class TestModelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
