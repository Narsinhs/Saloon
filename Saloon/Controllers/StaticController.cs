using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Saloon.Controllers
{
    public class StaticController : Controller
    {
        // GET: Static
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Haircut()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.User u)
        {
            if (u.login())
            {   
                return RedirectToAction("Index","User");
            }
            else { return RedirectToAction("login"); }
        }
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Models.User u)
        {
            if (ModelState.IsValid)
            {
                u.add();
                return RedirectToAction("Index");
            }

            return View();
        }
    }

}