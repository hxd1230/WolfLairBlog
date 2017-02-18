using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WolfLairBlog.Common.LogUtil;

namespace WolfLairBlog.Controllers
{
    public class NLogController : Controller
    {
        //
        // GET: /NLog/

        public ActionResult Index(string h)
        {
            //NLogHelper.Trace("Trace");
            //NLogHelper.Debug("Debug");
            //NLogHelper.Info("Info");
            //NLogHelper.Warn("Warn");
            //NLogHelper.Error("Error");
            //NLogHelper.Fatal("Fatal");
            try
            { 
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch (Exception ex)
            {
                NLogHelper.Error(LogUtility.GetExceptionDetails(ex));
            }
            return View();
        }
    }
}
