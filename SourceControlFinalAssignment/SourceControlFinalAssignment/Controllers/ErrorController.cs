﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SourceControlFinalAssignment.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PageNotFound()
        {
            return View();
        }
        public ActionResult BadRequest()
        {
            return View();
        }
        public ActionResult AccessForbidden()
        {
            return View();
        }
    }
}