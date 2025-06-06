using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager
{
    public class Operation
    {
        public string type;
        public decimal sum;
        public string time;

        public Operation(string t, decimal s)
        {
            type = t;
            sum = s;
            time = DateTime.Now.ToString();
        }
    }
}