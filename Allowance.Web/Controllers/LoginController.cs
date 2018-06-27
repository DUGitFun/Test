using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Allowance.Business;

namespace Allowance.Web.Controllers
{
    public class LoginController : Controller
    {
        public LoginController()
        {
            _LoginManager = new LoginManager();
        }

        private LoginManager _LoginManager;

        public ActionResult LoginHome()
        {
            var kidsLogin = _LoginManager.KidsListB();
            return View("Login", kidsLogin);
        }

        public ActionResult Login (string name, string password)
        {
            var userInfo = _LoginManager.UserLogin(name, password);
            if (userInfo != null)
            {
                return View("_Overview", userInfo);
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult LoginPartial()
        {
            return PartialView("_LoginPassword");
        }

        public ActionResult _Overview (object userInfo)
        {
            return View(userInfo);
        }
    }
}