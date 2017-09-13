﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DigiMovie.Models;
using System.Net;

namespace DigiMovie.Controllers
{
    public class CustomersController : Controller
    {
        #region BaseOperations
        private ApplicationDbContext db;
        public CustomersController()
        {
            db = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
        #endregion
        public ActionResult Index()
        {
            return View(db.Customers);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var customer = db.Customers.Include("MembershipType").SingleOrDefault(c=>c.Id==id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Name, bool IsSubscribedToNewsLetter, DateTime BirthDate)
        {
            var customer = new Customer
            {
                Name=Name, BirthDate=BirthDate, IsSubscribedToNewsLetter=IsSubscribedToNewsLetter, MembershipTypeId=1
            };
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}