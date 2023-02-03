using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class EmployeeWage
    {
        public void Attendance()
        {
            int EMP_WAGE_PER_HR = 20;
            int EmpHrs = 0;
            int Empwage = 0;
            int IS_EMP_FULL_TIME = 1;
            Random random = new Random();
            int empCheck=random.Next(0, 2);
            if (empCheck == IS_EMP_FULL_TIME)
                EmpHrs = 0;
            else
                EmpHrs = 8;
            Empwage = EmpHrs * EMP_WAGE_PER_HR;
            Console.WriteLine("EMployee Wage Per Hour Is :" +Empwage);
        }
    }
}
