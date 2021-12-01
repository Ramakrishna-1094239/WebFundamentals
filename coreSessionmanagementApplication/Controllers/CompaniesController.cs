﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreSessionmanagementApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreSessionmanagementApplication.Controllers
{
    public class CompaniesController : Controller
    {
        ApplicationDBContext context = new ApplicationDBContext();

        // GET: CountriesController
        public ActionResult Index()
        {
            var companies = context.Companies;
            return View(companies);
        }

        // GET: CountriesController/Details/5
        public ActionResult Details(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);
        }

        // GET: CountriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Company company)
        {
            try
            {
                context.Companies.Add(company);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CountriesController/Edit/5
        public ActionResult Edit(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);
        }

        // POST: CountriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Company company)
        {
            try
            {
                context.Companies.Update(company);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CountriesController/Delete/5
        public ActionResult Delete(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);
        }

        // POST: CountriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Company company)
        {
            try
            {

                var companyObj = context.Companies.Find(id);
                context.Companies.Remove(companyObj);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
