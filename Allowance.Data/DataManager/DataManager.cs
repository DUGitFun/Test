using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allowance.Data.DataManager
{
    public class DataManager
    {
        private DbEntities db = new DbEntities();

        public IEnumerable<Kid> Test()
        {
            var test = db.Kids.ToList();
            return test;
        }
    }
}
