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