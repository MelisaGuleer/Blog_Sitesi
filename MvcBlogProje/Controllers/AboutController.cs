using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Footer()
        {
            var aboutcontentlist1 = abm.GetAll();
            return PartialView(aboutcontentlist1);
        }
        public PartialViewResult MeetTheTeam()
        {
            return PartialView();
        }
    }
}