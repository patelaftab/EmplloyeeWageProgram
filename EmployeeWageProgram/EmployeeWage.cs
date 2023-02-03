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
            int IS_EMP_FULL_TIME=1;
            int IS_EMP_PART_TIME = 2;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case 1:IS_EMP_FULL_TIME:
                    EmpHrs = 8;
                    break;
                case 2:IS_EMP_PART_TIME:
                    EmpHrs = 4;
                    break;
                default:
                    EmpHrs = 0;
                    break;
            }
            Empwage = EmpHrs * EMP_WAGE_PER_HR;
            Console.WriteLine("EMployee Wage Per Hour Is :" +Empwage);
        }
    }
}
