using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OAuth.Api.Demo.Models;

namespace OAuth.Api.Demo.Controllers
{
    public class LessonsController : Controller
    {
        // GET: Lessons
        public ActionResult Index()
        {
            var lesson = new Lesson();
            return View(lesson);
        }
    }
}