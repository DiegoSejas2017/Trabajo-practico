using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W3_2018_2C_TP.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        { 
            return View();
        }
        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }
    }
}