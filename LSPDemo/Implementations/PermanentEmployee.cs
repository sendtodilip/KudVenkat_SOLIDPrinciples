using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo.Implementations
{
    class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name) : base(id, name)
        {
        }

        public override decimal CalulateBonus(decimal salary)
        {
            return salary * .1M;
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }
}
