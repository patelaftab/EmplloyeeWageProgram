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
        private string company;
        private int MAX_WORKING_HRS;
        private int MONTHLY_WORKING_DAYS;
        private int EMP_WAGE_PER_HR;
        private int totalEmpWage;
        public EmployeeWage(string company, int MAX_WORKING_HRS, int MONTHLY_WORKING_DAYS, int EMP_WAGE_PER_HR)
        {
            this.company = company;
            this.MAX_WORKING_HRS= MAX_WORKING_HRS;
            this.MONTHLY_WORKING_DAYS= MONTHLY_WORKING_DAYS;
            this.EMP_WAGE_PER_HR= EMP_WAGE_PER_HR;
        }
        public void Attendance()
        {
            int EmpHrs = 0, totalempHrs = 0, totalworkigDays = 0;
            Console.WriteLine("\nCalculating Wage For Company:- " + company+"\n");
            while (totalempHrs <= this.MAX_WORKING_HRS && totalworkigDays < this.MONTHLY_WORKING_DAYS)
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
                totalempHrs += EmpHrs;
                Console.WriteLine("Employee Working Days:" + totalworkigDays + " Employee Working Hrs :" + EmpHrs);
            }
            totalEmpWage = totalempHrs * EMP_WAGE_PER_HR;
            Console.WriteLine("Total Wage of Employee for Company :" +company +"Total Epployee Wage :"+ totalEmpWage);
        }
        public string tostring()
        {
            return "Total Emplaoyee Wage For Comapny :" + this.company + "is :" + this.totalEmpWage;
        }
    }
}
