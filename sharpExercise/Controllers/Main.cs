using Microsoft.AspNetCore.Mvc;

namespace sharpExercise.Controllers
{
    public class Main : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Page404()
        {
            return View();
        }
    }
}