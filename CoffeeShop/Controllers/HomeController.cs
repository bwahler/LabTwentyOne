using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We make coffee we can be proud of!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "We would be happy to answer any questions or concerns you might have!";

            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Welcome(User u)
        {
            ViewBag.FirstName = u.FirstName;
            ViewBag.LastName = u.LastName;
            ViewBag.Password = u.Password;
            ViewBag.Email = u.Email;
            ViewBag.PhoneNumber = u.PhoneNumber;
            ViewBag.gender = u.gender;
            ViewBag.BirthDate = u.BirthDate;
            ViewBag.CoffeeType = u.CoffeeType;
            return View();
        }
    }
}