using Microsoft.AspNetCore.Mvc;

namespace DotNet2.Mvc.Routing.Controllers
{
    [Route("work")]
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return Content("Work/Index");
        }

        [HttpGet("one")]
        public IActionResult PageOne()
        {
            return Content("Work/PageOne");
        }

        [Route("two")]
        public IActionResult PageTwo()
        {
            return Content("Work/PageTwo");
        }

        [Route("three/{id}")]
        public IActionResult PageThree(int id)
        {
            return Content($"Work/PageThree/{id}");
        }
    }
}