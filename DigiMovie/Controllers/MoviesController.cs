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
    public class MoviesController : Controller
    {
        #region BaseOperations
        private ApplicationDbContext db;
        public MoviesController()
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
            return View(db.Movies);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var movie = db.Movies.Include("Genre").SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        public ActionResult Create()
        {
            var moviesFormViewModel = new MoviesFormViewModel
            {
                Genres = db.Genres
            };
            return View(moviesFormViewModel);
        }
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            try
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                TempData["State"] = 1;
                return RedirectToAction("Index");
            }
            catch
            {
                TempData["State"] = 0;
                return RedirectToAction("Create");
            }

        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var movie = db.Movies.Find(id);
            if (movie == null)
                return HttpNotFound();
            var moviesFormViewModel = new MoviesFormViewModel
            {
                Movie = movie,
                Genres = db.Genres
            };
            return View(moviesFormViewModel);
        }
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            //Metod 1
            //var customerInDb = db.Customers.Find(customer.Id);
            //customerInDb.Name = customer.Name;
            //customerInDb.BirthDate = customer.BirthDate;
            //customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            //customerInDb.MembershipTypeId = customer.MembershipTypeId;
            //Metod 2
            db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
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
            var movie = db.Movies.Find(id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            try
            {
                db.SaveChanges();
                TempData["State"] = 5;
                return RedirectToAction("Index");
            }
            catch
            {
                TempData["State"] = 4;
                return RedirectToAction("Delete");
            }

        }
    }
}