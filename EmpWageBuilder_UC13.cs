using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class EmpWageBuilder_UC13 : IComputeMultipleCompany
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int empRatePerHour;
        private LinkedList<ComputeMultipleCompany> companyEmpWageList1;
        private Dictionary<string, ComputeMultipleCompany> companyToEmpWageMap1;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;

        public EmpWageBuilder_UC13()
        {
            this.companyEmpWageList1 = new LinkedList<ComputeMultipleCompany>();
            this.companyToEmpWageMap1 = new Dictionary<string, ComputeMultipleCompany>();
        }

        private void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            ComputeMultipleCompany computeEmpWage1 = new ComputeMultipleCompany(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList1.AddLast(computeEmpWage1);
            this.companyToEmpWageMap1.Add(company, computeEmpWage1);
        }

        public void ComputeEmpWage()
        {
            foreach (ComputeMultipleCompany computeEmpWage11 in this.companyEmpWageList1)
            {
                computeEmpWage11.setTotalEmpWage(this.computeEmpWage11(computeEmpWage11));
                Console.WriteLine(computeEmpWage11.toString());
            }
        }

        private int computeEmpWage11(ComputeMultipleCompany computeEmpWage11)
        {
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingHrs = 0;

            while (totalWorkingHrs <numOfWorkingDays && totalEmpHrs <=maxHoursPerMonth)
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
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            return totalEmpWage;

        }

        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap1[company].totalEmpWage;
        }

        internal void addCompanyEmpWage(string v1, int v2, int v3, int v4)
        {
            throw new NotImplementedException();
        }

        internal void computeEmpWage11()
        {
            throw new NotImplementedException();
        }
    }
}
