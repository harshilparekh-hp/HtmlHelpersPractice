using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelpersPractice.Models
{
    public class Employee
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public bool EmployeeTermsAndConditions { get; set; }
    }
}