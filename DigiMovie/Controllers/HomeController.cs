using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

using DigiMovie.Helper;

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
            return View();
        }
        [HttpPost]
        public ActionResult SendMail()
        {
            var Name = Request.Form["Name"];
            var mail = Request.Form["Email"];
            var Subject = Request.Form["Subject"];
            var Body = Request.Form["Body"];

            //1-define mailmessage
            var message = new MailMessage
            {
               // From=new MailAddress("alirezaghorbani230@gmail.com"),
                From = Email.GetMailAddress(EmailType.Info),
                Subject ="وب سایت دیجی مووی - قسمت ارتباط با ما",
                Body=string.Format("با عرض سلام پیام جدیدی از قسمت ارتباط با ما وب سایت دیجی مووی دریافت گردید"+
                "<hr>"+
                "نام :"+
                "{0}<hr>"+
                "ایمیل :"+
                "{1}<hr>"+
                "موضوع :"+
                "{2}<hr>"+
                "پیام :"+
                "{3}",Name,mail,Subject,Body),
                IsBodyHtml=true
            };
            //message.To.Add("alirezaghorbani230@gmail.com");
             message.To.Add(Email.GetMailName(EmailType.Info));

            //2-define smptclient
            //var smpt = new SmtpClient
            //{
            //    Host="smpt.gmail.com",
            //    EnableSsl=true,
            //    Port=587,
            //    UseDefaultCredentials=false,
            //    Credentials=new NetworkCredential { UserName= "alirezaghorbani230@gmail.com", Password="ghorbaniali67"}
            //};
            var smpt = Email.GetSmtp(EmailType.Info);

            //3-send
            try
            {
                smpt.Send(message);
                //ViewBag.Message="از ارسال پیام شما متشکریم";
                ViewBag.Status = 1;
            }
            catch 
            {
                //ViewBag.Message = "متاسفانه پیام شما ارسال نگردید، لطفا دوباره تلاش مجدد نمایید";
                ViewBag.Status = 0;
            }

            //ViewBag.Message = "Your contact page.";

            return View("Contact");
        }
        //[HttpPost]
        //public ActionResult ProcessForm(string firstname, string lastname)
        //{
        //    return Content("salam" + "-" + firstname + "-" + lastname);
        //}
    }
}