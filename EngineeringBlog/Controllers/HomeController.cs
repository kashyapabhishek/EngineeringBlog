using EngineeringBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EngineeringBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SubjectContext db = new SubjectContext();
            List<SubjectViewModel> sb = db.ConceptName.ToList();
            return View(sb);
        }

        [Authorize]
        [HttpGet]
        public ActionResult YourBot()
        {
            SubjectContext db = new SubjectContext();
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult YourBot(FormMethod s)
        {
            
            SubjectContext db = new SubjectContext();
            return View("/Home");
        }
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