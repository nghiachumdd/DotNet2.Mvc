using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNet2.Mvc.ModelBinding
{
    [Route("[controller]/[action]")]
    public class PersonController : Controller
    {
        //[Route("index")]
        public IActionResult Index()
        {
            return Content("Index page");
        }

        [Route("{id}")]
        public IActionResult Detail(int id)
        {
            return Content($"Detail with id: {id}");
        }

        [Route("{id}")]
        public IActionResult DetailQuery([FromQuery]int id)
        {
            return Content($"Detail query with id: {id}");
        }

        [HttpPost]
        public IActionResult Body([FromBody]PersonModel personModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Content($"The person's name is {personModel.Name}, and age is {personModel.Age}");
        }
    }
}
