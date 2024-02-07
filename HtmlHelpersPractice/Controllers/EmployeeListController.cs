using HtmlHelpersPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpersPractice.Controllers
{
    public class EmployeeListController : Controller
    {
        // GET: EmployeeList
        public ActionResult Index()
        {
            EmployeeBusinessLogic ebl = new EmployeeBusinessLogic();
            var employees = ebl.GetEmployees();
            return View(employees);
        }
    }
}