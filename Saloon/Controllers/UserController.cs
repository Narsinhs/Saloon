using System;
using Saloon.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Saloon.Controllers
{
    public class UserController : Controller
    {
        //Set Up Appointment Friday
        //Set Up Update Profile Friday
        // GET: User
        public ActionResult Index(Models.User u)
        {
            return View();
        }
        public ActionResult Signout()
        {
            Session["User"] = null;
            return RedirectToAction("Index", "Static");
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
        public ActionResult Appointment()
        {
            Models.Appointment_Master am = new Models.Appointment_Master();
            am.U_ID = Models.GetDetail.U_ID;
            List<Appointment_Master> app = am.getallappoint();
            return View(app);
        }
        public ActionResult AddAppointment()
        {
            Employee em = new Employee();
            ViewBag.emplist = em.all();
            return View();
        }
        [HttpPost]
        public ActionResult AddAppointment(Appointment_Master am)
        {
            am.U_ID = GetDetail.U_ID;
            am.add();
            return RedirectToAction("Appointment");
        }
        [HttpGet]
        public ActionResult DeleteAppointment(int a)
        {
            Models.Appointment_Master am = new Appointment_Master();
            am.Ap_ID = a;
            am.delete();
            return RedirectToAction("Appointment");
        }
        public ActionResult AppointmentProduct(int a)
        {
            Product p = new Product();
            TempData["A"] = a;
            List<Product> pp = p.productsbyappointment(a);
            return View(pp);
        }
        public ActionResult AppointmentFacility(int a)
        {
            Facilities f = new Facilities();
            TempData["A"] = a;
            return View(f.byappointment(a));
        }
        public ActionResult AppointmentPackages(int a)
        {
            Package p = new Package();
            TempData["A"] = a;
            return View(p.packagebyappointment(a));
        }
        public ActionResult AddFacility(Appointment_Facilities ap)
        {
            ap.Ap_ID = Convert.ToInt32(TempData["A"]);
            ap.add();
            return RedirectToAction("AppointmentFacility");
        }
    }
}