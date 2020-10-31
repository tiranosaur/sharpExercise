using System;
using System.Linq;
using System.Text;
using System.Xml;
using Microsoft.AspNetCore.Mvc;

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
                FillByDate(date.ToString("dd/MM/yyyy"));
            }

            return Redirect("/currency/index");
        }

        private void FillByDate(string dateString)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            
            XmlDocument xml = new XmlDocument();
            xml.Load($"{this.xmlUrl}{dateString}");
            XmlElement rootNode = xml.DocumentElement;
            DateTime date = DateTime.ParseExact(rootNode.Attributes[0].Value, "dd.MM.yyyy", null);
            foreach (XmlNode xnode in rootNode)
            {
                Models.Currency currency = new Models.Currency();
                currency.valuteID = xnode.Attributes[0].Value;
                currency.numCode = Int32.Parse(xnode.ChildNodes[0].InnerText);
                currency.сharCode = xnode.ChildNodes[1].InnerText;
                currency.nominal = Int32.Parse(xnode.ChildNodes[2].InnerText);
                currency.name = xnode.ChildNodes[3].InnerText;
                currency.value = Double.Parse(xnode.ChildNodes[4].InnerText);
                currency.date = date;
                db.Add(currency);
            }
            db.SaveChanges();
        }
    }
}