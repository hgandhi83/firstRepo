﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //My first comment
        //My first comment
        //My first comment
        //My first comment
        //My first comment
        //My first comment
        //My first comment
        //My first comment
        //My first comment
        //My firstHalf Comment
        //My firstHalf Comment
        //My firstHalf Comment
        //My firstHalf Comment
        //My firstHalf Comment
        //My firstHalf Comment
        //My firstHalf Comment
        //My firstHalf Comment
        //My second comment
        //My second comment
        //My second comment
        //My second comment
        //My second comment
        public ActionResult About()
        {
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
