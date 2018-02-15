using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class Lab4Controller : Controller
    {
        // GET: Lab4
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Page2(int id)
        {
            return View(id);
        }


        public ActionResult Page3()
        {
            ViewBag.Title = "Beverages";
            string[] drinks = { "Coffee", "Tea", "Beer", "Coke", "Wine" };
            ViewData["drinks"]=drinks;
            return View(drinks);
        }
    }
}