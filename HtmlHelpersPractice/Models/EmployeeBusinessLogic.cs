using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelpersPractice.Models
{
    public class EmployeeBusinessLogic
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee()
            {
                EmployeeFirstName = "Harshil",
                EmployeeLastName = "Parekh",
                Country = "Canada",
                Gender = "Male",
                EmployeeTermsAndConditions = true
            }
        };

        public bool AddEmployee(Employee emp)
        {
            Employees.Add(emp);
            return true;
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }
    }
}