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
        // GET: User
        public ActionResult Index(Models.User u)
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
        public ActionResult Appointment()
        {
            Models.Appointment_Master am = new Models.Appointment_Master();
            am.U_ID = Models.GetDetail.U_ID;
            List<Appointment_Master> app = am.getallappoint();
            if (app.Count > 0)
            {
                am = app[0];
            }
            return View(app);
        }
        [HttpGet]
        public ActionResult AddAppointment()
        {
            Employee em = new Employee();
            ViewBag.idname = em.all();
            return View();
        }
        [HttpPost]
        public ActionResult AddAppointment(Appointment_Master apm)
        {
            apm.add();
            return RedirectToAction("AddFacAppointment");
        }
        [HttpGet]
        public ActionResult AddFacAppointment()
        {
            Facilities f = new Facilities();
            ViewBag.Facall = f.all();
            return View();
        }
        [HttpPost]
        public ActionResult AddFacAppointment(Appointment_Facilities af)
        {
            Appointment_Master m = new Appointment_Master();
            m.getlastid();
            af.Ap_ID = m.Ap_ID;
            af.add();
            return RedirectToAction("AdFacAppointment");
        }
        [HttpGet]
        public ActionResult AddProductAppointment()
        {
            Product p = new Product();
            ViewBag.appro = p.all();
            return View();
        }
        [HttpPost]
        public ActionResult AddProductAppointment(Appointment_Product ap)
        {
            Appointment_Master am = new Appointment_Master();
            am.getlastid();
            ap.Ap_ID = am.Ap_ID;
            ap.add();
            return RedirectToAction("AddProductAppointment");
        }
        [HttpGet]
        public ActionResult AddPackageAppointment()
        {
            Package p = new Package();
            ViewBag.Packages = p.all();
            return View();
        }
        [HttpPost]
        public ActionResult AddPackageAppointment(Appointment_Package ap)
        {
            Appointment_Master am = new Appointment_Master();
            am.getlastid();
            ap.Ap_ID = am.Ap_ID;
            am.add();
            return RedirectToAction("Appointment");
        }
    }
}