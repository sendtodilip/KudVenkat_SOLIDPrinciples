using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmployeeType { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name, string employeeType)
        {
            this.ID = id; this.Name = name; this.EmployeeType = employeeType;
        }
        public decimal CalcualteBonus(decimal salary)
        {
            if (this.EmployeeType == "Parmanent")
                return salary * .1M;
            else
                return salary * .05M;
        }
        public override string ToString()
        {
            return string.Format("ID: {0} Name: {1}", this.ID, this.Name);
        }
    }
}
