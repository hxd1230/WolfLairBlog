using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WolfLairBlog.Common.LogUtil;
using WolfLairBlog.Entity.DB;
using WolfLairBlog.IBusinessLogicLayer;

namespace WolfLairBlog.Controllers
{
    public class FuncController : Controller
    {
        public IUserService _userService;
        public FuncController(IUserService userService)
        {
            _userService = userService;
        }
        public ActionResult Index()
        {
            Trace.WriteLine("一般信息");
            Trace.TraceInformation("告知性信息");
            Trace.TraceWarning("警告信息");
            Trace.TraceError("错误信息");
           // NLogHelper.Debug("log信息");
            NLogHelper.Trace("Trace Message");
            NLogHelper.Debug("Debug Message");
            NLogHelper.Info("Info Message");
            NLogHelper.Error("Error Message");
            NLogHelper.Fatal("Fatal Message");
              IQueryable<User> user = _userService.Select(c => true);

            return View(user);
        }
    }
}
