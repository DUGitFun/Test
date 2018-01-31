using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}