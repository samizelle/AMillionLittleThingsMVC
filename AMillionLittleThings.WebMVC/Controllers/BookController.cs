using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AMillionLittleThings.Models;

namespace AMillionLittleThings.WebMVC.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            var model = new BookListItem[0];
            return View(model);
        }

        // GET: Book
        public ActionResult Create()
        {
            var model = new BookListItem[0];
            return View();
        }

        // POST: Book
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}