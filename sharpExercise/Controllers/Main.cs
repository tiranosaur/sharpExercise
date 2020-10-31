using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

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
       
        [HttpGet]
        public string Try()
        {
            HttpClient client = new HttpClient();
            Task<HttpResponseMessage> response = client.GetAsync("http://localhost:5000/user/indexjson");
            string result = response.Result.Content.ReadAsStringAsync().Result;
            return result;
        }
    }
}