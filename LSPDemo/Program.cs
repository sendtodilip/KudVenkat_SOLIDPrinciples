using LSPDemo.Implementations;
using LSPDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "John"));
            employees.Add(new TemporaryEmployee(2, "Jason"));
            //employees.Add(new ContractEmployee(1, "John"));


            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} Minimum Salary: {2}",
              employee.ToString(),
              employee.CalulateBonus(100000).ToString(), 
              employee.GetMinimumSalary().ToString()));
                Console.ReadLine();
            }

            List<IEmployee> employeesOnly = new List<IEmployee>();
            employeesOnly.Add(new PermanentEmployee(1, "John"));
            employeesOnly.Add(new TemporaryEmployee(2, "Jason"));
            employeesOnly.Add(new ContractEmployee(3 , "Mike"));


            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0}  Minimum Salary: {1}",
              employee.ToString(),
              employee.GetMinimumSalary().ToString()));
                Console.ReadLine();
            }


        }
    }
}
