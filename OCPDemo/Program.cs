using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //without OCP
            /*Employee empJohn = new Employee(1, "John", "Parmanent");
            Employee empJason = new Employee(1, "Jason", "Temp");


            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJohn.ToString(),
                empJohn.CalcualteBonus(100000).ToString()));
            Console.ReadLine();

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              empJason.ToString(),
              empJason.CalcualteBonus(150000).ToString()));
            Console.ReadLine();*/

            EmployeeWithOCP empJohn = new PermanentEmployee(1, "John");
            EmployeeWithOCP empJason = new TemporarytEmployee(1, "Jason");


            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJohn.ToString(),
                empJohn.CalcualteBonus(100000).ToString()));
            Console.ReadLine();

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              empJason.ToString(),
              empJason.CalcualteBonus(150000).ToString()));
            Console.ReadLine();
        }
    }
}
