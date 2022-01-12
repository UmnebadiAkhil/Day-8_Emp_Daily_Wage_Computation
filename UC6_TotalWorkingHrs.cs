using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    internal class UC6_TotalWorkingHrs
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;

        public void TotalWorkingHrs()
        {
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingHrs = 0;
            //Computation
            while (totalWorkingHrs < NUM_OF_WORKING_DAYS && totalEmpHrs <= MAX_WORKING_HRS)
            {
                totalWorkingHrs++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day# : " + totalWorkingHrs + " Emp Hrs : " + empHrs );
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
