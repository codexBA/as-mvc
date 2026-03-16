using AS.MVCFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AS.MVCFramework.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employees = new List<Employee>();

            Employee emp1 = new Employee
            {
                Name = "Amel",
                Position = "Pozicija 1"
            };

            Employee emp2 = new Employee
            {
                Name = "Branislava",
                Position = "Pozicija 2"
            };

            Employee emp3 = new Employee
            {
                Name = "Vesna",
                Position = "Pozicija xy"
            };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            return View(employees);
        }
    }
}