using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace sharpExercise.Controllers
{
    public class User : Controller
    {
        internal ApplicationContext db = new ApplicationContext();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Users = db.users.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Show(int Id)
        {
            ViewBag.User = db.users.FirstOr(x => x.Id == Id, null);
            if (ViewBag.User == null) return Redirect("/user/index");
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            ViewBag.User = db.users.FirstOr(x => x.Id == Id, null);
            if (ViewBag.User == null) return Redirect("/user/index");
            return View();
        }

        [HttpPost]
        public IActionResult Store()
        {
            int.TryParse(Request.Form["Id"], out int Id);
            var user = db.users.FirstOr(x => x.Id == Id, null);
            if (user == null)
            {
                user = new Models.User();
                db.Add(user);
            }

            user.Username = Request.Form["Username"];
            user.Email = Request.Form["Email"];
            db.SaveChanges();
            return Redirect("/user/index");
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var user = db.users.FirstOr(x => x.Id == Id, null);
            if (user != null)
            {
                db.users.Remove(user);
                db.SaveChanges();
            }

            return Redirect("/user/index");
        }
    }
}