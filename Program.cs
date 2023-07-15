using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main ( string[] args)
         {
           Console.WriteLine("Welcome to Employee Wage Computation Problem");
            EmployeeWage appleWage = new EmployeeWage("Apple", 200, 20, 100);
            //employeeWage.EmployeeAttendance();
            appleWage.CalculateEmpWage();
            EmployeeWage amazonWage = new EmployeeWage("Amazon", 100, 20, 100);
            amazonWage.CalculateEmpWage();
        }

    }
}
