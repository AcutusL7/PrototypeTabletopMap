using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website_ViewLayer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Daedalus!";
            return View();
        }

        public ActionResult ChangeMessage()
        {
            ViewBag.Message = "Change";
            return View();
        }
    }
}