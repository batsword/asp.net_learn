﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        //GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        //// 
        //// GET: /HelloWorld/ 
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}
        //// 
        //// GET: /HelloWorld/Welcome/  
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}
    }
}