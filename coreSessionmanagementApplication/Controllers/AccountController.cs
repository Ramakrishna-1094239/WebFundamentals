using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreSessionmanagementApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login(String userName , String Password)
        {
            if (userName != null&& Password!=null)
            {
                if(userName.Equals("admin")&&(Password.Equals("Admin")))
                    {
                    HttpContext.Session.SetString("uname", userName);

                    return View("Success");              
                   }
                else
                {
                    ViewBag.Error = "Invalid Creds";
                    return View("Index");

                }

            }
            else
            {
                ViewBag.Error = "Enter Creds";
                return View("Index");
            }


           

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");

        }
    }
}
