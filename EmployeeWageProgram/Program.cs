using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Program");
            EmployeeWage employeeWage= new EmployeeWage("D-Mart", 100, 15, 20);
            EmployeeWage employeewage = new EmployeeWage("Slice", 150, 25, 20);
            employeeWage.Attendance();
            Console.WriteLine(employeeWage.tostring());
            employeewage.Attendance();
            Console.WriteLine(employeeWage.ToString());
            Console.ReadLine();
        }
    }
}
