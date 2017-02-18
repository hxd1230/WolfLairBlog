using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WolfLairBlog.Controllers
{
    public class WolfLairController : Controller
    {
        //
        // GET: /WolfLair/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Doing()
        {
            return View();
        }
    }
}
