using System;
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

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        //
        // GET: HelloWorld/Welcome
        public string Welcome(string name, int numTime = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTime is: " + numTime);
        }
    }
}
