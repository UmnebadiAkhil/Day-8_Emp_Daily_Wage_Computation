using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<ComputeEmpWage> companyEmpWageList;
        private Dictionary<string, ComputeEmpWage> companyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<ComputeEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, ComputeEmpWage>();
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            ComputeEmpWage computeEmpWage = new ComputeEmpWage( company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(computeEmpWage);
            this.companyToEmpWageMap.Add(company, computeEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach(ComputeEmpWage computeEmpWage1 in this.companyEmpWageList)
            {
                computeEmpWage1.setTotalEmpWage(this.computeEmpWage(computeEmpWage1));
                Console.WriteLine(computeEmpWage1.toString());
            }
        }

        private int computeEmpWage(ComputeEmpWage computeEmpWage)
        {
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingHrs = 0;

            while (totalWorkingHrs < computeEmpWage.numOfWorkingDays && totalEmpHrs <= computeEmpWage.maxHoursPerMonth)
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
                Console.WriteLine("Day# : " + totalWorkingHrs + " Emp Hrs : " + empHrs);

            }
            int totalEmpWage = totalEmpHrs * computeEmpWage.empRatePerHour;
            return totalEmpWage;
            
        }

        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}
