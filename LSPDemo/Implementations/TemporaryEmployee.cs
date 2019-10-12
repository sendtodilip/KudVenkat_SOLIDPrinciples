using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo.Implementations
{
    class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string name) : base(id, name)
        {
        }

        public override decimal CalulateBonus(decimal salary)
        {
            return salary * 0.5M;
        }

        public override decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
