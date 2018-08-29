using Microsoft.AspNetCore.Mvc;

namespace DotNet2.Mvc.Routing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is index page");
        }

        public IActionResult PageOne()
        {
            return Content("This is page one");
        }

        //[HttpGet]
        public IActionResult PageTwo()
        {
            return Content("This is page two");
        }

        [HttpPost]
        public IActionResult PageTwo(int id)
        {
            return Content($"(Post) This is page two: {id}");
        }
    }
}