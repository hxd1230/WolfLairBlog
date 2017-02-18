using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WolfLairBlog.Common;
using WolfLairBlog.Entity.DB;
using WolfLairBlog.IBusinessLogicLayer;

namespace WolfLairBlog.Controllers
{
    public class AccountController : Controller
    {
        IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult ShowValidateCode()
        {
            ValidateCode validateCode = new ValidateCode();
            string code = validateCode.CreateValidateCode(4);
            Session["code"] = code;
            byte[] buffer = validateCode.CreateValidateGraphic(code);
            return File(buffer, "image/jpeg");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            PublicStruct<User, string> outInfo;
            bool flag = _userService.Login(user.UserName, user.UserPwd, out outInfo);
            if (flag)
            {
                string sessionId = Guid.NewGuid().ToString();
                Response.Cookies["sessionId"].Value = sessionId;
                if (!string.IsNullOrEmpty(Request["rememberMe"]))
                {
                    //记住我，添加到cookie
                    HttpCookie userName = new HttpCookie("username", user.UserName);
                    HttpCookie passWord = new HttpCookie("password", FuncUtility.Encrypt(user.UserPwd));
                    userName.Expires = DateTime.Now.AddDays(3);
                    passWord.Expires = DateTime.Now.AddDays(3);
                    Response.Cookies.Add(userName);
                    Response.Cookies.Add(passWord);
                }
                if (!string.IsNullOrEmpty(Request["from"]))
                {
                    return Redirect(Request["from"]);
                }
                else
                {
                    return RedirectToAction("Index", "WolfLair");
                }
            }
            else
            {
                ViewData["msg"] = outInfo.String;
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (CheckVCode())
            {
                user.RegisterTime = DateTime.Now;
                user.UserPwd = FuncUtility.Encrypt(user.UserPwd);
                string msg = string.Empty;
                if (_userService.AddEntity(user, out msg))
                {
                    return RedirectToAction("Login", "Account");
                }
                _userService.AddEntity(user);
            }
            else
            {
                ViewData["msg"] = "验证码错误！";
            }
            return View();
        }
        private bool CheckVCode()
        {
            if (Session["code"] != null)
            {
                string requestCode = Request["code"];
                string sessionCode = Session["code"].ToString();
                if (sessionCode.Equals(requestCode, StringComparison.InvariantCultureIgnoreCase))
                {
                    Session["code"] = null;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
