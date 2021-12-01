using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCConcepts.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCConcepts.Controllers
{
    public class StudentController : Controller
    {

        public static List<Student> students = new List<Student>()
        {
            new Student(){StudentID=101,Name="Stu1",City="BNG",Gender="Male"},
            new Student(){StudentID=102,Name="Stu2",City="BNG",Gender="FeMale"},
            new Student(){StudentID=103,Name="Stu3",City="BNG",Gender="Male"},
            new Student(){StudentID=104,Name="Stu4",City="BNG",Gender="Male"},
        };



        public IActionResult Index()
        {
            ViewBag.Message = "Student Management System";
            ViewBag.StudentCount = students.Count;
            ViewBag.StudentList = students;

            return View();
        }

        public IActionResult Details()
        {
            if(ViewBag.Message ==null)
            {
                ViewBag.NewMessage = "Success";
            }

            else
            {
                ViewBag.NewMessage = ViewBag.Message;
            }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Student Management System";
            ViewData["StudentCount"] = students.Count;
            ViewData["StudentList"] = students;
            ViewBag.Message = "Students Here";
            return View();
        }

        public IActionResult Info()
        {
            TempData["Message"] = "Student Management System";
            TempData["StudentCount"] = students.Count;
            TempData["StudentList"] = students;

            return View();

        }

        public IActionResult RequestA()
        {
            //TempData["Msg"] = "Helo World";
            //return RedirectToAction("RequestB");

            TempData["Msg"] = "Helo World";
            return View();
        }

        public IActionResult RequestB()
        {
            if (TempData["Msg"] as string != null)

            {
                TempData["Msg"] = TempData["Msg"];
                return View();

            }
            else

            return RedirectToAction("Index");      

        }

        public IActionResult StudentData()
        {
            return View(students);

        }

    }
}
