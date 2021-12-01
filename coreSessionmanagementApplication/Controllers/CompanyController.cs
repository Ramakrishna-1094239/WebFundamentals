using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coreSessionmanagementApplication.Models;

namespace coreSessionmanagementApplication.Controllers
{
    public class CompanyController : Controller
    {
        ApplicationDBContext context = new ApplicationDBContext();


        public IActionResult Index()
        {
            var companies = context.Companies.ToList();
            return View(companies);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Company Company)
        {
            context.Companies.Add(Company);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Details(int Id)
        {
            // var company = context.Companies.Find(Id);

            var company = context.Companies.Where(c => c.CompanyID == Id).FirstOrDefault();//.FirstodDefault();
            return View(company);
;        }


        public IActionResult Delete(int Id)
        {
            var company = context.Companies.Find(Id);
            return View(company);
        
        }

        [HttpPost]
        public IActionResult Delete(int id, Company company)
        {
            var companyObj = context.Companies.Find(id);
            context.Companies.Remove(companyObj);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);

        }

        [HttpPost]
        public IActionResult Edit(Company company)
        {
            context.Companies.Update(company);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
