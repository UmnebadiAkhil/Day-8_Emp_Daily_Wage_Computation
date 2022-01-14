// See https://aka.ms/new-console-template for more information
using EmployeeWageComputationProblem;

Console.WriteLine(" Hello, World! ");
Console.WriteLine(" Welcome to Employee Wage Computation Program on Master Branch");
Console.WriteLine(" _____________________________________________________________\n");

bool flag = true;
while (flag)
{
    Console.WriteLine("Enter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.UC-4, \n 5.UC-5, \n 6.UC-6, \n 7.UC-7, \n 8.UC-8_MultipleCompanies, \n 9.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            UC1_EmployeeCheck uc1 = new UC1_EmployeeCheck();
            uc1.EmployeeCheck();
            break;
        case 2:
            EmployeeWageComputationProblem.UC2_DailyEmployeeWage uc2 = new UC2_DailyEmployeeWage();
            uc2.DailyEmployeeWage();
            break;
        case 3:
            EmployeeWageComputationProblem.UC3_EmployeeWagePartTime uc3 = new UC3_EmployeeWagePartTime();
            uc3.EmployeeWagePartTime();
            break;
        case 4:
            EmployeeWageComputationProblem.UC4_SwitchCase uc4 = new UC4_SwitchCase();
            uc4.SwichCase();
            break;
        case 5:
            EmployeeWageComputationProblem.UC5_WagesForAMonth uc5 = new UC5_WagesForAMonth();
            uc5.WagesForAMonth();
            break;
        case 6:
            EmployeeWageComputationProblem.UC6_TotalWorkingHrs uc6 = new UC6_TotalWorkingHrs();
            uc6.TotalWorkingHrs();
            break;
        case 7:
            UC7_ReactorTheCode.computeEmpWage();
            break;
        case 8:
            ComputeEmpWageClass computeEmpWageClass = new ComputeEmpWageClass();
            computeEmpWageClass.computeEmpWage("Dmart", 20, 20, 100);

            computeEmpWageClass.computeEmpWage("Reliance", 25, 20, 100);
            break;
        case 9:
            flag = false;
            break;
    }
}
