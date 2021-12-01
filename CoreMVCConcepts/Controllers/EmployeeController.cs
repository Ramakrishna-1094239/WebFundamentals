using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCConcepts.Models
{
    public class EmployeeController : Controller
    {
        //    public JsonResult Index()
        //    {
        //        EmployeeRepository employeeRepository = new EmployeeRepository();
        //        var employees = employeeRepository.GetEmployee();
        //        return Json(employees);
        //    }
        EmployeeRepository employeeRepository = new EmployeeRepository();

        //IEmployeeRepository employeeRepository;

        //public EmployeeController (IEmployeeRepository _employeeRepository)
        //{
        //    employeeRepository = _employeeRepository;
        //}

        public IActionResult Index()
        {
            
            var employees = employeeRepository.GetEmployee();
            return View(employees);
        }

        public IActionResult Details(int Id)
        {
            var employees = employeeRepository.GetEmployeeByID(Id);
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create (Employee employee)
        {
            employeeRepository.AddEmployee(employee);
            return RedirectToAction("index");

        }

    }
}
