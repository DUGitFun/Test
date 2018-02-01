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
            //var kidsReturn = kidsD.Cast<Models.Models.Kids>().ToList(); //todo fix invalid cast
            return kidsD;
        }
    }
}
