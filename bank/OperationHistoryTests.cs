using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager
{
    public class OperationHistory
    {
        private List<Operation> ops = new List<Operation>();

        public void Add(string type, decimal sum)
        {
            ops.Add(new Operation(type, sum));
        }

        public List<Operation> GetAll()
        {
            return ops;
        }

        public void Clear(decimal balance)
        {
            ops.Clear();
            ops.Add(new Operation("Очистка истории", balance));
        }
    }
}