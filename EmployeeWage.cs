using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8;
        public void EmployeeAttendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);//returns value 0, 1
            if (empCheck == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");

        }
        public void CalculateEmpWage() 
        {
            int dailyEmpWage = WAGE_PER_HR * FULL_DAY_HR;
            Console.WriteLine(dailyEmpWage);
        }
    }
}
