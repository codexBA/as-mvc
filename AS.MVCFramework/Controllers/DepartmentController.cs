using AS.MVCFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AS.MVCFramework.Controllers
{
    public class DepartmentController : Controller
    {
        // Naziv View-a je isti kao naziv akcije/metode
        public ActionResult Index()
        {
            List<Department> departments = new List<Department>
            {
                new Department { Name = "IT", Address = "123 Tech Street" },
                new Department { Name = "HR", Address = "456 Human Resources Ave" },
                new Department { Name = "Finance", Address = "789 Finance Blvd" }
            };
            //
            ViewBag.Naslov = "Lista odjela";
            //
            return View(departments);
        }
    }
}