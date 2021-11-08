using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Creating a data set.";

            return View();

        }

            public ActionResult About()
        {
            //thing done
            ViewBag.Message = "Dax o gå hem.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult 8thOfNovAddition()
        {
            ViewBag.Message = "New controller.";

            return View();
        }

    }
}