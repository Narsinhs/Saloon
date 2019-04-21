using System;
using Saloon.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Saloon.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        //CRUD PRODUCT
        [HttpGet]
        public ActionResult Products()
        {
            Product p = new Product();
            return View(p.all());
        }
        [HttpGet]
        public ActionResult UpdateProduct(int a)
        {
            Product p = new Product();
            p.P_id = a;
            p.search();
            return View(p);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product p)
        {
            p.update();
            return RedirectToAction("Products");
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            p.add();
            return RedirectToAction("Products");
        }
        [HttpGet]
        public ActionResult DeleteProduct(int a)
        {
            Product p = new Product();
            p.P_id = a;
            p.delete();
            return RedirectToAction("Products");
        }
        //------------------------------------------------------------//Checked.
        //CRUD Package
        [HttpGet]
        public ActionResult Package()
        {
            Package p = new Package();
            return View(p.all());

        }
        [HttpGet]
        public ActionResult AddPackage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPackage(Package p)
        {
            p.add();
            return RedirectToAction("Package");
        }
        [HttpGet]
        public ActionResult DeletePackage(int a)
        {
            Package p = new Models.Package();
            p.P_ID = a;
            p.delete();
            return RedirectToAction("Package");
        }
        [HttpGet]
        public ActionResult UpdatePackage(int a)
        {
            Package p = new Models.Package();
            p.P_ID = a;
            p.Search();
            return View(p);
        }
        [HttpPost]
        public ActionResult UpdatePackage(Package p)
        {
            p.update();
            return RedirectToAction("Package");
        }
        //------------------------------------------------------------//Checked.
        //CRUD FACILITIES
        [HttpGet]
        public ActionResult Facilities()
        {
            Facilities f = new Models.Facilities();
            return View(f.all());
        }
        [HttpGet]
        public ActionResult AddFacilities()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFacilities(Facilities f)
        {
            f.add();
            return RedirectToAction("Facilities");
        }
        [HttpGet]
        public ActionResult DeleteFacilities(int a)
        {
            Facilities f = new Models.Facilities();
            f.F_ID = a;
            f.delete();
            return RedirectToAction("Facilities");
        }
        [HttpGet]
        public ActionResult UpdateFacilities(int a)
        {
            Facilities f = new Models.Facilities();
            f.F_ID = a;
            f.search();
            return View(f);
        }
        [HttpPost]
        public ActionResult UpdateFacilities(Facilities f)
        {
            f.update();
            return RedirectToAction("Facilities");
        }


        //------------------------------------------------------------//Checked.
        //CRUD EXPENSE
        [HttpGet]
        public ActionResult Expense()
        {
            Expense ex = new Models.Expense();
            return View(ex.all());
        }
        public ActionResult AddExpense()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExpense(Expense e)
        {
            e.add();
            return RedirectToAction("Expense");
        }
        [HttpGet]
        public ActionResult DeleteExpense(int a)
        {
            Expense e = new Models.Expense();
            e.E_ID = a;
            e.delete();
            return RedirectToAction("Expense");
        }
        [HttpGet]
        public ActionResult UpdateExpense(int a)
        {
            Expense e = new Models.Expense();
            e.E_ID = a;
            e.search();
            return View(e);
        }
        [HttpPost]
        public ActionResult UpdateExpense(Expense e)
        {
            e.update();
            return RedirectToAction("Expense");
        }
        //------------------------------------------------------------//Checked.
        //CRUD EMPLOYEE
        public ActionResult Employee()
        {
            Employee em = new Models.Employee();
            return View(em.all());
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee e)
        {
            e.add();
            return RedirectToAction("Employee");
        }
        public ActionResult DeleteEmployee(int a)
        {
            Employee em = new Models.Employee();
            em.E_ID = a;
            em.delete();
            return RedirectToAction("Employee");
        }
        [HttpGet]
        public ActionResult UpdateEmployee(int a)
        {
            Employee em = new Models.Employee();
            em.E_ID = a;
            em.search();
            return View(em);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee e)
        {
            e.update();
            return RedirectToAction("Employee");
        }
        //------------------------------------------------------------//Checked.
        public ActionResult Exp_Cat()
        {
            Exp_Cat ec = new Exp_Cat();
            return View(ec.all());
        }
        [HttpGet]
        public ActionResult AddExp_Cat()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExp_Cat(Exp_Cat ec)
        {
            ec.add();
            return RedirectToAction("Exp_Cat");
        }
        [HttpGet]
        public ActionResult UpdateExp_Cat(int a)
        {
            Exp_Cat ec = new Models.Exp_Cat();
            ec.EC_ID = a;
            ec.search();
            return View(ec);
        }
        [HttpPost]
        public ActionResult UpdateExp_Cat(Exp_Cat ec)
        {
            ec.update();
            return RedirectToAction("Exp_Cat");
        }
        [HttpGet]
        public ActionResult DeleteExp_Cat(int a)
        {
            Exp_Cat ec = new Models.Exp_Cat();
            ec.EC_ID = a;
            ec.delete();
            return RedirectToAction("Exp_Cat");
        }

        //------------------------------------------------------------//Checked.
        [HttpGet]
        public ActionResult Designation()
        {
            Designation d = new Models.Designation();
            return View(d.all());
        }
        [HttpGet]
        public ActionResult AddDesignation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDesignation(Designation d)
        {
            d.add();
            return RedirectToAction("Designation");
        }
        [HttpGet]
        public ActionResult UpdateDesignation(int a)
        {
            Designation d = new Models.Designation();
            d.D_ID = a;
            d.search();
            return View();
        }
        [HttpPost]
        public ActionResult UpdateDesignation(Designation d)
        {
            d.update();
            return RedirectToAction("Designation");
        }
        [HttpGet]
        public ActionResult DeleteDesignation(int a)
        {
            Designation d = new Models.Designation();
            d.D_ID = a;
            d.delete();
            return RedirectToAction("Designation");
        }
        [HttpGet]
        public ActionResult Department()
        {
            Department d = new Models.Department();
            return View(d.all());
        }
        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartment(Department d)
        {
            d.add();
            return RedirectToAction("Department");
        }
        [HttpGet]
        public ActionResult UpdateDepartment(int a)
        {
            Department d = new Models.Department();
            d.Dep_ID = a;
            d.update();
            return View(d);
        }
        [HttpPost]
        public ActionResult UpdateDepartment(Department d)
        {
            d.update();
            return RedirectToAction("Department");
        }
        [HttpGet]
        public ActionResult User()
        {
            User u = new Models.User();
            return View(u.alluser());
        }
        [HttpGet]
        public ActionResult DeleteUser(int a)
        {
            User u = new Models.User();
            
            u.U_ID = a;
            u.delete();
            return RedirectToAction("User");
        }
        [HttpGet]
        public ActionResult Getallappointment()
        {
            Appointment_Master am = new Appointment_Master();
            
            return View(am.all());
        }
    }
}