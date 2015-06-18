using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.portfolio1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "This is my default action";
        }

        public ActionResult MainPage()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Resume()
        {
            return View();
        }
        public ActionResult Apps()
        {
            return View();
        }
        public ActionResult ContactMe()
        {
            return View();
        }
        public ActionResult Links()
        {
            return View();
        }

    }
}
