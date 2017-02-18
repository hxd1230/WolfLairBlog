using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WolfLairBlog.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Temp()
        {
            return View();
        }
        public ActionResult TempDetails()
        {
            return View();
        }
    }
}
