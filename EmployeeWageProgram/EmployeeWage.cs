using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class EmployeeWage
    {
        const int IS_EMP_FULL_TIME = 0, IS_EMP_PART_TIME = 1;
        public void Attendance(string company,int MAX_WORKING_HRS,int MONTHLY_WORKING_DAYS,int EMP_WAGE_PER_HR)
        {
            int EmpHrs = 0, Totalempwage = 0, empwage = 0;
            int totalworkigDays = 0, totalempHrs = 0, totalEMpWage = 0;
            Console.WriteLine("\nCalculating Wage For Company" + company+"\n");
            while (totalempHrs < MAX_WORKING_HRS && totalworkigDays < MONTHLY_WORKING_DAYS)
            {
                totalworkigDays++;
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
                empwage = EmpHrs * EMP_WAGE_PER_HR;
                totalempHrs += EmpHrs;
                Console.WriteLine("Employee Working Days:" + totalworkigDays + " Employee Working Hrs :" + empwage);
                 totalEMpWage+= empwage;
            }
            Totalempwage = empwage * EMP_WAGE_PER_HR;
            Console.WriteLine("Total Wage of Employee is :" + Totalempwage +"Total Epployee Hrs :"+totalempHrs);
        }
    }
}
