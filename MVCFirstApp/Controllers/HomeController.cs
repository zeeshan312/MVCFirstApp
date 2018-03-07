using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache (Duration =20)]
        public string  Index()
        {
            return "hello  world";
        }

        [OutputCache(Duration =10)]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyView()
        {
            return View();
        }
    }
}