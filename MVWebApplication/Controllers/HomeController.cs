using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            return View();

        }
        public ViewResult Contact()
        {
            return View();

        }

        public IActionResult Privacy()
        {
            return RedirectToAction("Index");

        }

        public string Message()
        {
            return "Message Action Method-Home Controller";

        }
    }
}
