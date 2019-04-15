using QronosProgrammeringsuppgift.XmlHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace QronosProgrammeringsuppgift.Controllers
{
    public class HomeController : Controller
    {
        private readonly XmlDocument _xmlDocument = new XmlDocument();
        public HomeController()
        {
            _xmlDocument.Load("C:\\Users\\Abbe\\source\\repos\\QronosProgrammeringsuppgift\\QronosProgrammeringsuppgift\\XmlFiles\\books.xml");
        }
        public ActionResult Index(string searchByOperator, string searchParameter)
        {
            var books = XmlDocumentHandler.GetBooksFromDocument(_xmlDocument);
            ViewBag.Title = "Book Search";

            if (!String.IsNullOrEmpty(searchByOperator) || !String.IsNullOrEmpty(searchParameter))
            {
                if (searchByOperator == "Title")
                {
                    return View(books.Where(x => x.title.IndexOf(searchParameter, StringComparison.OrdinalIgnoreCase) >= 0 || searchParameter == null).ToList());
                }
                if (searchByOperator == "Id")
                {
                    return View(books.Where(x => x.id == searchParameter.ToUpper() || searchParameter == null).ToList());
                }
            }
            else
            {
                return View(books);
            }
            return null;

        }
    }
}
