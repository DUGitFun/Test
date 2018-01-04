using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allowance.Weekly
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Data.DataManager.DataManager();

            var result = test.Test();
        }
    }
}
