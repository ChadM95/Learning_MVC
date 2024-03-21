using Microsoft.AspNetCore.Mvc;
using Test_MVC.Models;

namespace Test_MVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            Person p1 = new Person("Chad",28);
            
            return View(p1);
        }
    }
}
