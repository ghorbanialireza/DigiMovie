using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DigiMovie.Models;
using System.Net;
using DigiMovie.ViewModels;

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
            var customersFormViewModel = new CustomersFormViewModel {
                MembershipTypes=db.MembershipTypes
            };
            return View(customersFormViewModel);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                TempData["State"]= 1;
                return RedirectToAction("Index");
            }
            catch 
            {
                TempData["State"] = 0;
                return RedirectToAction("Crete");
            }

        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var customer = db.Customers.Find(id);
            if (customer == null)
                return HttpNotFound();
            var customersFormViewModel = new CustomersFormViewModel
            {
                Customer = customer,
                MembershipTypes = db.MembershipTypes
            };
            return View(customersFormViewModel);
        }
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            //Metod 1
            //var customerInDb = db.Customers.Find(customer.Id);
            //customerInDb.Name = customer.Name;
            //customerInDb.BirthDate = customer.BirthDate;
            //customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            //customerInDb.MembershipTypeId = customer.MembershipTypeId;
            //Metod 2
            db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            try
            {
                db.SaveChanges();
                TempData["State"] = 3;
                return RedirectToAction("Index");
            }
            catch 
            {
                TempData["State"] = 2;
                return RedirectToAction("Edit");
            }
            
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var customer = db.Customers.Find(id);
            if (customer == null)
                return HttpNotFound();
            
            return View(customer);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            try
            {
                db.SaveChanges();
                TempData["State"] = 5;
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                TempData["State"] = 4;
                return RedirectToAction("Delete");
            }
           
        }
    }
}