using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Allowance.Web.Controllers
{
    public class AllowanceController : Controller
    {
        // GET: Allowance
        public ActionResult Overview()
        {
            return View();
        }
    }
}