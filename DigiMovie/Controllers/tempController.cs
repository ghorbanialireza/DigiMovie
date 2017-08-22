﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigiMovie.Controllers
{
    public class tempController : Controller
    {
        // GET: temp
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult MvcHelper()
        {
            return View();
        }

        public ActionResult AjaxActionLinkProcess()
        {
            return Content("salam");
        }

        public ActionResult MvcBeginForm()
        {
            return View();
        }

        public ActionResult MvcBeginFormProcess(string FirstName)
        {
            return Content("salam"+FirstName);
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult IndexChangeTheme()
        {
            ViewBag.ThemeName = "~/Views/Shared/" + Request.Form["theme"] + ".cshtml";
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Test")]
        public ActionResult TestChangeTheme()
        {
           ViewBag.ThemeName = "~/Views/Shared/" + Request.Form["theme"] + ".cshtml";
            return View();
        }

        
        public ActionResult RawAjax()
        {
            return View();
        }

        public ActionResult RawAjaxProcess(string name)
        {
            return Content("salam");
        }

        public ActionResult RawAjaxGetProcess()
        {
            return Content("SALAM " + Request.QueryString["name"] + "\n" + "Sale Tavalvod : " + (1396 - Convert.ToInt32(Request.QueryString["age"])));
        }
        [HttpPost]
        public ActionResult RawAjaxPostProcess()
        {
            return Content("SALAM " + Request.Form["name"] + "\n" + "Sale Tavalvod : " + (1396 - Convert.ToInt32(Request.Form["age"])));
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult ProcessForm(string firstname,
            string lastname,
            string password,
            string address,
            bool agreement,
            string gender,
            int city,
            int fruits,
            DateTime currentTime)
        {
            ViewBag.Message = "salam" + "-" + firstname + "-" + lastname;
            return View();
        }

        //[Route("gallery/{year:int:range(1300,1400)}/{month:int:range(1,12)}/{message}")]
        //public ActionResult Show(int year, int month, string message)
        //{
        //    return Content(year + "<br>" + month + "<br>" + message);
        //}


    }
}