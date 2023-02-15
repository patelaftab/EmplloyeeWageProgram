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
            EmployeeWage employeeWage= new EmployeeWage();
            employeeWage.Attendance("D-Mart",100,15,20);
            employeeWage.Attendance("Slice", 150, 25, 20);
            Console.ReadLine();
        }
    }
}
