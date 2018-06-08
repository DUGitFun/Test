using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allowance.Models;

namespace Allowance.Business
{
    public class LoginManager
    {
        public LoginManager()
        {
            _dataAccess = new Data.DataManager.DataManager();
        }

        private Data.DataManager.DataManager _dataAccess;

        public IEnumerable<Models.ViewModels.LoginViewModel> KidsListB()
        {
            var kidsB = _dataAccess.LoginList();
            return kidsB;
        }

        public object UserLogin (string name, string password)
        {
            var userInfo = _dataAccess.UserLogin(name, password);
            return userInfo;
        }
    }
}
