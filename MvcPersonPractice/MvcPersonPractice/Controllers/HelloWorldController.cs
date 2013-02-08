﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPersonPractice.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: HelloWorld/Welcome
        public ActionResult Welcome(string name, int numTime = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTime;

            return View();
        }
    }
}
