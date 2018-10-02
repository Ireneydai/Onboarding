using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            ViewBag.Message = "Your  product page.";

            return View();
        }

        public ActionResult Customer()
        {
            ViewBag.Message = "Your customer page.";

            return View();
        }

        public ActionResult Store()
        {
            ViewBag.Message = "Your Store page.";

            return View();
        }

        public ActionResult Sale ()
        {
            ViewBag.Message = "Your sale page.";

            return View();
        }
    }
}