using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AMillionLittleThings.Models;

namespace AMillionLittleThings.WebMVC.Controllers
{
    [Authorize]
    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult Index()
        {
            var model = new MusicListItem[0];
            return View();
        }
    }
}