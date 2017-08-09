using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigiMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //return Content("salam:");
            //return RedirectToAction("About");
             //return HttpNotFound();
            //return new EmptyResult();
            //return View("About");
            //return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
        }
        
        public ActionResult About(/*int? id,string message*/)
        {
            //if (id == null)

            //    return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            //return Content(id.ToString() + "<hr>" + message);


            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}