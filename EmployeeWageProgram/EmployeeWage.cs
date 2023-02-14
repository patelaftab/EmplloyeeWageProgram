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
            int MONTHLY_WORKING_DAYS = 20;
            const int  IS_EMP_FULL_TIME = 1, IS_EMP_PART_TIME = 2;
            int EmpHrs = 0, Empwage = 0, totalempwage = 0;
            for (int Day = 1; Day <= MONTHLY_WORKING_DAYS; Day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_EMP_FULL_TIME:
                        EmpHrs = 8;
                        break;
                    case IS_EMP_PART_TIME:
                        EmpHrs = 4;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                Empwage = EmpHrs * EMP_WAGE_PER_HR;
                Console.WriteLine("wage  :"+Empwage + " For day :"+Day );
                totalempwage += Empwage;
            }
            Console.WriteLine("\nTotal Wage of Employee For a Month is :"+totalempwage);
        }
    }
}
