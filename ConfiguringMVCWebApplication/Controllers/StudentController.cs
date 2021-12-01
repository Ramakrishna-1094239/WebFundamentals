using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConfiguringMVCWebApplication.Models;

namespace ConfiguringMVCWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> students = new List<Student>()
        {
        new Student(){StudentId=101,Name="Stu1",City="BNG",Gender="Male"},
        new Student(){StudentId=101,Name="Stu2",City="BNG1",Gender="Female"},
        new Student(){StudentId=101,Name="Stu3",City="BNG1",Gender="male"},
        new Student(){StudentId=101,Name="Stu4",City="BNG1",Gender="Female"}
        //new Student(){},
        //new Student()
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
            return View();
        }

    }
}
