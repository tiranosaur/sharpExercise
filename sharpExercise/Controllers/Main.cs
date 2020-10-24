using Microsoft.AspNetCore.Mvc;

namespace sharpExercise.Controllers
{
    public class Main : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Page404()
        {
            return View();
        }
    }
}