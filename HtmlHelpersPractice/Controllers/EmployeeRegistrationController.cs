using HtmlHelpersPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpersPractice.Controllers
{
    public class EmployeeRegistrationController : Controller
    {
        // GET: EmployeeRegistration
        public ActionResult Index()
        {
            return View();
        }

       

        public ActionResult Register(string EmployeeName, string EmployeeLastName, string Gender, string Country, bool TermsConditions)
        {
            EmployeeBusinessLogic ebl = new EmployeeBusinessLogic();
            Employee emp = new Employee();
            emp.EmployeeFirstName = EmployeeName;
            emp.EmployeeLastName = EmployeeLastName;
            emp.Gender = Gender;
            emp.Country = Country;
            emp.EmployeeTermsAndConditions = TermsConditions;
            if (ebl.AddEmployee(emp))
                return RedirectToAction("Index", "EmployeeList");

            return null; // exception

        }

        public ActionResult EmployeeRegistration()
        {
            return View();
        }

        public ActionResult RegisterScaffolding(Employee emp)
        {
            EmployeeBusinessLogic ebl = new EmployeeBusinessLogic();
            ebl.AddEmployee(emp);
            return RedirectToAction("Index", "EmployeeList");
        }
    }
}