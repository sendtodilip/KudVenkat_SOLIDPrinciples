using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo
{
    public abstract class EmployeeWithOCP
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public EmployeeWithOCP(int id, string name)
        {
            this.ID = id; this.Name = name;
        }
        public abstract decimal CalcualteBonus(decimal salary);
        public override string ToString()
        {
            return string.Format("ID: {0} Name: {1}", this.ID, this.Name);
        }
    }

    public class PermanentEmployee : EmployeeWithOCP
    {
        public PermanentEmployee(int id, string name): base(id, name)
        {

        }
        public override decimal CalcualteBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class TemporarytEmployee : EmployeeWithOCP
    {
        public TemporarytEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalcualteBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}
