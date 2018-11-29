using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AMillionLittleThings.Models;

namespace AMillionLittleThings.WebMVC.Controllers
{
    [Authorize]
    public class StreamingController : Controller
    {
        // GET: Streaming
        public ActionResult Index()
        {
            var model = new StreamingListItem[0];
            return View(model);
        }

        // GET: Streaming
        public ActionResult Create()
        {
            return View();
        }
    }
}