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
                Id = x.id,
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

        //todo write hasing for password saving, storage, retrieval
        public object UserLogin (string name, string password)
        {
            var userInfo = db.Login.Where(x => x.Name == name && x.Password == password).ToList();
            if (userInfo != null)
            {
                var id = userInfo[0].id;
                var allowanceData = AllowanceOverview(id);
                return allowanceData;
                
            }
            return null;
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

        public object AllowanceOverview(int id)
        {
            var data = db.Database.SqlQuery<Models.ViewModels.AllowanceInfo>(Constants.AllowInfo + " ' " + id + " ' ");
            //var data = db.Kids.SqlQuery(Constants.AllowanceInfoJoin + " ' " + id + " ' ").ToList();
            //var allowanceInfo = new Models.ViewModels.AllowanceInfo
            //{
            //    id = data[0].id,
            //    Name = data[0].Name,
            //    Expr1 = data[0].Expr1,
            //    Value = data[0].Value,

            //}; //TODO : fix
            return data;
        }
    }
}
