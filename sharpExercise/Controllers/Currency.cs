using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using sharpExercise.Models;

namespace sharpExercise.Controllers
{
    public class Currency : Controller
    {
        internal ApplicationContext db = new ApplicationContext();

        private string xmlUrl = @"http://www.cbr.ru/scripts/XML_daily.asp?date_req=";

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Currencies = db.currencies.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Fill()
        {
            DateTime date = DateTime.Today;
            for (int i = 0; i <= 30; i++)
            {
                date = date.AddDays(i);
                FillByDate(date);
            }

            return Redirect("/currency/index");
        }

        private void FillByDate(DateTime date)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ValCurs));

            HttpClient client = new HttpClient();
            ValCurs result = (ValCurs) xmlSerializer.Deserialize(
                client
                    .GetAsync("http://www.cbr.ru/scripts/XML_daily.asp?date_req=02/03/2002")
                    .Result.Content.ReadAsStreamAsync().Result
            );
            foreach (Valute item in result)
            {
                item.date = date;
                db.Add(item);
            }

            db.SaveChanges();
        }
    }
}