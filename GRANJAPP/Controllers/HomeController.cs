using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GRANJAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Servicio()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Reg_animal()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Bus_animal()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult company()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}