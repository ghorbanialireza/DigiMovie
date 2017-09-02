using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DigiMovie.Models;
using System.Net;

namespace DigiMovie.Controllers
{
    ResturanEntities db;
    public class FoodsController : Controller
    {
        public FoodsController()
        {
            db = new ResturanEntities();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult Index()
        {
            return View(db.Foods);
        }
        public ActionResult Details(int id)
        {
            var food = db.foods.Find(id);
            if (food == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return View(food);
        }
        public ActionResult Creat()
        {
            var food = new Food
            {
                Name = "کتلت",
                IsExsist = true,
                NumberAvailable = 125,
                Description = "خوشمزه",
                CategoryId = 4
            };

            try
            {
                db.Foods.Add(food);
                db.SaveChang();
                //throw new Exception();
                TempData["CreatStat"] = 1;
            }
            catch
            {
                TempData["CreatStat"] = 0;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            try
            {
            var food = db.foods.Find(id);
            if (food == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            db.Foods.Remove(food);
            db.SaveChang();
            TempData["DeleteStat"] = 1;
            }
            catch 
            {

                TempData["DeleteStat"] = 0;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            try
            {
                var food = db.foods.Find(id);
                if (food == null)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                food.NumberAvailable = 600;
                db.SaveChang();
                TempData["EditStat"] = 1;
            }
            catch
            {

                TempData["EditStat"] = 0;
            }
            return RedirectToAction("Index");
        }
    }
}