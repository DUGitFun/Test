using Allowance.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allowance.Web.Tests.Login
{
    class LoginTest
    {
        [TestMethod]
        public void LoginList()
        {
            LoginController Login = new LoginController();
            var result = Login.LoginHome();

        }

        [TestMethod]
        public void Login()
        {
            LoginController Login = new LoginController();
            var userName = "Mason";
            var password = "1234";
            var loginResult = Login.Login(userName, password);

        }
    }
}
