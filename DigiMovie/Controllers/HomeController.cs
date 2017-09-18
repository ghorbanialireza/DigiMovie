using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

using DigiMovie.Helper;
using DigiMovie.Models;

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
            //return new EmptyResult();
            return View();
        }

        [HttpPost]
        public ActionResult SetLayout(string layout)
        {
            return View("About", "~/Views/Shared/_" + layout + ".cshtml");
        }

        [HttpPost]
        public ActionResult SendMail()
        {
            var message = new MailMessage
            {
                From = Email.GetMailAddress(EmailType.Info),
                Subject ="وب سایت دیجی مووی - قسمت ارتباط با ما",
                Body=string.Format("نام :"+
                "{0}<hr>"+
                "ایمیل :"+
                "{1}<hr>"+
                "موضوع :"+
                "{2}<hr>"+
                "پیام :"+
                "{3}", Request.Form["Name"], Request.Form["Email"], Request.Form["Subject"], Request.Form["Body"]),
                IsBodyHtml=true
            };
            message.To.Add(Email.GetMailName(EmailType.Info));
            var smtp = Email.GetSmtp(EmailType.Info);
            try
            {
                smtp.Send(message);
                ViewBag.Status = 1;
            }
            catch
            {
                ViewBag.Status = 0;
            }

            return View("Contact");
        }
        //[HttpPost]
        //public ActionResult ProcessForm(string firstname, string lastname)
        //{
        //    return Content("salam" + "-" + firstname + "-" + lastname);
        //}
    }
}