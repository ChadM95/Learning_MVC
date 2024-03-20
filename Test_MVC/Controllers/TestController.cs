using Microsoft.AspNetCore.Mvc;
using Test_MVC.Models;

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
    
        public IActionResult DisplayList()
        { 
            //create list of model objects
            List<TestModel> TestList = new List<TestModel>();

            Models.TestModel Test = new Models.TestModel
            {
                Category = "Flowers",
                Name = "TestFlower",
                Description = "Great For Testing Models",
                Amount = 100
            };

            Models.TestModel Test1 = new Models.TestModel
            {
                Category = "Shpuds",
                Name = "TestShpud",
                Description = "Great For Getting Spuddy",
                Amount = 105
            };

            TestList.Add(Test);
            TestList.Add(Test1);

            return View(TestList);
        }
    
    }
}
