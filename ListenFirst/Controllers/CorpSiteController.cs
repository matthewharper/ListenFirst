using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListenFirst.Controllers
{
    public class CorpSiteController : Controller
    {
        // GET: CorpSite
        public ActionResult Index()
        {
            return View("CompanyHome");
        }
    }
}