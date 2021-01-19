using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_najehacademy.Controllers
{
    public class TestGitController : Controller
    {
        // GET: TestGit
        public ActionResult Index()
        {
            ViewBag.MyName = "Ammary";
            return View();
        }
       
    }
}