using LSPDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public abstract decimal CalulateBonus(decimal salary);

        public abstract decimal GetMinimumSalary();
        public override string ToString()
        {
            return string.Format("ID: {0} Name: {1}", this.ID, this.Name);
        }
    }
}
