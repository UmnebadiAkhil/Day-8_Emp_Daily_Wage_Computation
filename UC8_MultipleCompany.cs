using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    interface UC8_MultipleCompany
    {
        public int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int MaxHoursPerMonth);
    }
}
