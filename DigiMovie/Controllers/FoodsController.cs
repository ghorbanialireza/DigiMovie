using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DigiMovie.Models;
using System.Net;

namespace DigiMovie.Controllers
{
    public class FoodsController : Controller
    {
        public ActionResult Index()
        {
            var db = new ResturanEntities() { };
            return View(db.Foods);
        }
        public ActionResult Details(int id)
        {
            var db = new ResturanEntities() { };
            var food = db.foods.Find(id);
            if (food == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return View(food);
        }
        public ActionResult Creat()
        {
            var db = new ResturanEntities() { };
            return View(db.Foods);
        }
        public ActionResult Delete()
        {
            var db = new ResturanEntities() { };
            return View(db.Foods);
        }
        public ActionResult Edit()
        {
            var db = new ResturanEntities() { };
            return View(db.Foods);
        }
    }
}