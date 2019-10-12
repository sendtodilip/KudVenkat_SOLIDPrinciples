using LSPDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo.Implementations
{
    class ContractEmployee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
