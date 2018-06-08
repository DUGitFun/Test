using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allowance.Models;

namespace Allowance.Data.DataManager
{
    public class DataManager
    {
        private DbEntities db = new DbEntities();

        public IEnumerable<Models.ViewModels.LoginViewModel> LoginList()
        {
            var kidsD = db.Kids.ToList();
            var kidsReturn = kidsD.Select(x => new Models.ViewModels.LoginViewModel
            {
                Name = x.Name,
                Gender = x.Gender
            });
            return kidsReturn;
        }

        public object Test()
        {
            var kidsD = db.Kids.ToList();
            var kidsReturn = kidsD.Select(x => new Models.ViewModels.LoginViewModel
            {
                Name = x.Name,
                Gender = x.Gender
            });
            return kidsReturn;
        }

        public object UserLogin (string name, string password)
        {
            //byte[] pass = Encoding.ASCII.GetBytes(password);
            //var userInfo = db.Password.Where(x => x.PasswordHash.Contains(pass));
            var userInfo = 6;
            return userInfo;
        }

        public bool SaveInfo(string name, string password)
        {
            //var info = db.Password.FirstOrDefault(x => x.PasswordHash.Contains(name));
            //if (!info)
            //{
            //    //save info
            //    return true;
            //}
            return false;
        }
    }
}
