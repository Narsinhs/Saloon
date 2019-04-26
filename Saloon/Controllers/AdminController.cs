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
        //Layout - Template Setup - Saturday
        //Apply Validation - Friday
        //REPORT - EXPENSE,USER,APPOINTMENT - Saturday

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin ad)
        {
            if (ad.login())
            {
                Session["Admin"] = ad.A_ID;
                return RedirectToAction("Dashboard");
            }
            else
            {
                ad.error = "Invalid name or password";
                return View(ad);
            }
        }
        public ActionResult Signout()
        {
            Session["Admin"] = null;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Dashboard()
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
        public ActionResult PackFacilitiesList(int a)
        {
            TempData["P_ID"] = a;
            Facilities f = new Models.Facilities();
            return View(f.bypackage(a));
        }
        [HttpGet]
        public ActionResult DeleteFacility(int a)
        {
            Package_Facilities pf = new Package_Facilities();
            pf.P_ID = Convert.ToInt32(TempData["P_ID"]);
            pf.F_ID = a;
            pf.delete();
            return RedirectToAction("PackFacilitiesList",new { a = pf.P_ID });

        }
        //Session Validation Done
        [HttpGet]
        public ActionResult AddPackFac()
        {
            Facilities f = new Models.Facilities();
            ViewBag.Fac = f.all();
            return View();
        }
        [HttpPost]
        public ActionResult AddPackFac(Package_Facilities f)
        {
            Package p = new Models.Package();
            f.P_ID = Convert.ToInt32(TempData["P_ID"]);
            f.add();
            return RedirectToAction("PackFacilitiesList",new {a = f.P_ID });
        }
        [HttpGet]
        public ActionResult DeletePackage(int a)
        {
            Package p = new Models.Package();
            p.P_ID = a;
            p.delete();
            Package_Facilities pf = new Package_Facilities();
            pf.P_ID = a;
            pf.delete();
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
            Exp_Cat ec = new Models.Exp_Cat();
            ViewBag.ec = ec.all();
            if (TempData["type"] != null)
            {
                if (TempData["type"] == "ecid")
                {
                    ex.EC_Name = TempData["value"].ToString();
                    ec.searchbyname();
                    return View(ex.expensebyecid());
                }
                else
                {
                    ex.Name = (string)TempData["value"];
                    return View(ex.expbyname());
                }
            }
            return View(ex.all());
        }
        [HttpGet]
        public ActionResult SearchDetails(string name,string ecid,string expname)
        {
            if (ecid != null)
            {
                TempData["type"] = "ecid";
                TempData["value"] = name;
            }
            else if (expname != null)
            {

                TempData["type"] = "expname";
                TempData["value"] = name;
            }
            return RedirectToAction("Expense");
        }
        public ActionResult AddExpense()
        {
            Exp_Cat ec = new Models.Exp_Cat();
            ViewBag.Expcat = ec.all();
            return View();
        }
        [HttpPost]
        public ActionResult AddExpense(Expense e)
        {
            Admin ad = new Admin();
            ad.A_ID = Convert.ToInt32(Session["Admin"]);
            ad.searchbyid();
            e.Add_By = ad.Name;
            e.add();
            Exp_Cat ec = new Models.Exp_Cat();
            ViewBag.expcat = ec.all();
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
            Exp_Cat ec = new Models.Exp_Cat();
            ViewBag.Expcat = ec.all();
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
            if (TempData["Evalue"] != null)
            {
                if (TempData["Evalue"] == "did")
                {
                    em.D_Name = TempData["Edata"].ToString();
                    TempData["Evalue"] = null;
                    TempData["Edata"] = null;
                    return View(em.searchbydesignation());
                }
                else if (TempData["Evalue"] == "depid")
                {
                    em.Dep_Name = TempData["Edata"].ToString();
                    TempData["Evalue"] = null;
                    TempData["Edata"] = null;
                    return View(em.searchbydepartment());
                }
                else {
                    em.Name = TempData["Edata"].ToString();
                    TempData["Evalue"] = null;
                    TempData["Edata"] = null;
                    return View(em.searchbyname());
                }
            }
            return View(em.all());
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            Department dp = new Models.Department();
            ViewBag.depid = dp.all();
            Designation dsg = new Designation();
            ViewBag.ddddd = dsg.all();
            return View();
        }
        [HttpGet]
        public ActionResult SearchDetailsEmployee(string name,string did,string depid,string ename)
        {
            if (did != null)
            {
                TempData["Evalue"] = "did";
                TempData["Edata"] = Convert.ToInt32(name);
            }
            else if (depid != null)
            {

                TempData["Evalue"] = "depid";
                TempData["Edata"] = Convert.ToInt32(name);
            }
            else if (ename != null)
            {

                TempData["Evalue"] = "ename";
                TempData["Edata"] = name;
            }
            return RedirectToAction("Employee");
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
            Department dp = new Models.Department();
            ViewBag.depp = dp.all();
            Designation dsg = new Models.Designation();
            ViewBag.dd = dsg.all();
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
            return View(d);
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
            d.search();
            return View(d);
        }
        [HttpPost]
        public ActionResult UpdateDepartment(Department d)
        {
            d.update();
            return RedirectToAction("Department");
        }
        [HttpGet]
        public ActionResult DeleteDepartment(int a)
        {
            Models.Department d = new Models.Department();
            d.Dep_ID = a;
            d.delete();
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
        public ActionResult Admins()
        {
            Admin ad = new Admin();
            return View(ad.all());
        }
        [HttpGet]
        public ActionResult AppStatus(int a)
        {
            Appointment_Master am = new Appointment_Master();
            am.Ap_ID = a;
            am.search();
            am.Status = !am.Status;
            am.update();
            return RedirectToAction("Getallappointment");
        }
        public ActionResult DetailsFacilities(int a)
        {
            Facilities f = new Models.Facilities();
            return View(f.byappointment(a));

        }
        public ActionResult DetailsPackages(int a)
        {
            Package p = new Models.Package();
            return View(p.packagebyappointment(a));
        }
        public ActionResult DetailsProducts(int a)
        {
            Product p = new Product();
            return View(p.productsbyappointment(a));
        }
        public ActionResult SearchAppointment(string name, string Uname,string Empname)
        {
            if (Uname != null)
            {
                TempData["Evalue"] = "Uname";
                TempData["Edata"] = name;
            }
            else if (Empname != null)
            {

                TempData["Evalue"] = "Empname";
                TempData["Edata"] = name;
            }
            return RedirectToAction("Getallappointment");
        }
        [HttpGet]
        public ActionResult Getallappointment()
        {
            Appointment_Master am = new Appointment_Master();
            if (TempData["Evalue"] != null)
            {
                if (TempData["Evalue"] == "Uname")
                {
                    am.U_Name = TempData["Edata"].ToString();
                    User u = new Models.User();
                    u.Name = am.U_Name;
                    u.getbyname();
                    am.U_ID = u.U_ID;
                    TempData["Evalue"] = null;
                    TempData["Edata"] = null;
                    return View(am.getallappoint());
                }
                else
                {
                    am.E_Name = TempData["Edata"].ToString();
                    Employee em = new Models.Employee();
                    em.Name = am.E_Name;
                    em.getidbyname();
                    am.E_ID = em.E_ID;
                    return View(am.getallappointemp());
                }

            }
            return View(am.all());
        }
    }
}