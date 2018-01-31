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

        public IEnumerable<Models.Models.Kids> LoginList()
        {
            var kidsD = db.Kids.ToList();
            return kidsD;
        }
    }
}
