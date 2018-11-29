﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AMillionLittleThings.Models;

namespace AMillionLittleThings.WebMVC.Controllers
{
    [Authorize]
    public class WebController : Controller
    {
        // GET: Web
        public ActionResult Index()
        {
            var model = new WebListItem[0];
            return View(model);
        }

        // GET: Web
        public ActionResult Create()
        {
            return View();
        }
    }
}