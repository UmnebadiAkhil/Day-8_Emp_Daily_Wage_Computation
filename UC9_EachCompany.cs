﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class UC9_EachCompany
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int empRatePerHour;
        private int totalEmpWage;
        

        public UC9_EachCompany(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.numOfWorkingDays = numOfWorkingDays;
            this.empRatePerHour = empRatePerHour;
            this.maxHoursPerMonth = maxHoursPerMonth;
            
        }

        public int computeEmpWage11()
        {
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingHrs = 0;

            while (totalWorkingHrs < numOfWorkingDays && totalEmpHrs <= maxHoursPerMonth)
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day# : " + totalWorkingHrs + " Emp Hrs : " + empHrs);

            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for company: " + company + " is " + totalEmpWage);
            return totalEmpWage;

        }

        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is " + this.totalEmpWage;
        }
    }
}