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

        public IEnumerable<Models.Models.Kids> KidsListB()
        {
            var kidsB = _dataAccess.LoginList();
            return kidsB;
        }
    }
}
